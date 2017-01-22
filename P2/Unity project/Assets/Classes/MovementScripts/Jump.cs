using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    public Vector3 springen;
    public Rigidbody rgbd;
    public float hoogte;


	void Start () {

	
	}
	
	void OnCollisionEnter()
    {
        hoogte = 0;

    }

	void Update () {
	
        if (Input.GetButtonDown("Jump"))
        {
            hoogte = hoogte + 1;
            if (hoogte < 4)
            {
                rgbd.velocity = springen;
            }
           
        }

	}
    
}
