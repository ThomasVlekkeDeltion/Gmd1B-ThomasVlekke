using UnityEngine;
using System.Collections;

public class BallSpawn : MonoBehaviour
{

    public float power;
    public GameObject prefab;
    public GameObject pinballSpawn;
    public bool ball;

    void SpawnPinball()
    {

        //Ik maak een gameobject aan door een prefab (een balletje) te gebruiken die ik ook gelijk afschiet. 
        GameObject pinball = (GameObject)Instantiate(prefab, pinballSpawn.GetComponent<Transform>().position, pinballSpawn.GetComponent<Transform>().rotation);

        pinball.GetComponent<Rigidbody>().velocity = pinballSpawn.GetComponent<Transform>().transform.forward * power;
    }

    void Update()
    {
        //Ik zeg hier dat als ik de rechter muis knop in druk, dat hij dan een balletje afschiet, en als lives meer is dan 0 dat hij dan een bal mag spawnen, zo niet, dan niet.
        if(Input.GetButtonDown("Fire2"))
        {
            if (GameObject.Find("Manager").GetComponent<Lives>().lives > 0)
            {
                if (ball == false)
                {
                    SpawnPinball();
                }
            }
            //hier zeg ik dat het niet mogelijk is om een bal te spawnen
            ball = true;
        }
    }
}