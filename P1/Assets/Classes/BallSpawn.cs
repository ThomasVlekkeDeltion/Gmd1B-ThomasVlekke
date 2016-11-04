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

        GameObject pinball = (GameObject)Instantiate(prefab, pinballSpawn.GetComponent<Transform>().position, pinballSpawn.GetComponent<Transform>().rotation);

        pinball.GetComponent<Rigidbody>().velocity = pinballSpawn.GetComponent<Transform>().transform.forward * power;
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            if (GameObject.Find("Manager").GetComponent<Lives>().lives > 0)
            {
                if (ball == false)
                {
                    SpawnPinball();
                }
            }
            ball = true;
        }
    }
}