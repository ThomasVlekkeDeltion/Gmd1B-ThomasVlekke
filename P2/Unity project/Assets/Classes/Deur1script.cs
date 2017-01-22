using UnityEngine;
using System.Collections;

public class Deur1script : MonoBehaviour {

	void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "steen")
        {
            Destroy(GameObject.Find("Deur 1"));
        }
       
    }


	void Start () {
	
	}
	
	

	void Update () {
	
	}
}
