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
        // als er collision word gemaakt moet 'hoogte' 0 worden
        hoogte = 0;

    }

	void Update () {

	 // als spatie word ingedrukt moet 'hoogte', 'hoogte' + 1 worden en als hoogte nog kleiner dan 4 is moet het object waar het script op staat velocity omhoog krijgen
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
