using UnityEngine;
using System.Collections;

public class Deur1script : MonoBehaviour {

    public bool vernietigd;

	void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "steen")
        {
            //Hier zeg ik dat als het object waarmee het contact maakt een tag genaamd "steen" heet, hij zichzelf moet vernietigen
            Destroy(GameObject.Find("Deur 1"));
            vernietigd = true;
        }
       
    }


	void Start () {
	
	}
	
	

	void Update () {
	
	}
}
