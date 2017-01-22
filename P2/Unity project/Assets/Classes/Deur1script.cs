using UnityEngine;
using System.Collections;

public class Deur1script : MonoBehaviour {


	void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "steen")
        {
            //Hier zeg ik dat als het object waarmee het contact maakt een tag genaamd "steen" heet, hij zichzelf moet vernietigen
            Destroy(GameObject.Find("Deur 1"));
        }
       
    }


	void Start () {
	
	}
	
	

	void Update () {
	
	}
}
