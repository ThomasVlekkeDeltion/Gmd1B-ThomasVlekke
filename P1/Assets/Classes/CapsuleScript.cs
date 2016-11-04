using UnityEngine;
using System.Collections;

public class CapsuleScript : MonoBehaviour {

    public GameObject cylinder;
    public GameObject prefab;


    void OnCollisionEnter()
    {
        //Hier destroy ik de capsule en spawn ik een tweede balletje door middel van de prefab
        Destroy(gameObject);
        GameObject pinball = (GameObject)Instantiate(prefab, cylinder.GetComponent<Transform>().position, cylinder.GetComponent<Transform>().rotation);
        
    }
}
