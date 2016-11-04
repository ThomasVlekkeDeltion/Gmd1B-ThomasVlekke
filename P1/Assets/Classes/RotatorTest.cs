using UnityEngine;
using System.Collections;

public class RotatorTest : MonoBehaviour {


    public float flipperStrength;
    public float pushForce;
    private HingeJoint hinge; 


	// Use this for initialization
	void Start () {
        hinge = GetComponent<HingeJoint>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetButtonDown("Jump"))
        {
            //De flippers draaien nu rond de hinge joint door middel van transform.up *  flipperstrength (=9000) en (transform.right) + transform.position * pushForce (=4500)
            Vector3 f = -transform.up * flipperStrength;
            Vector3 p = (transform.right) + transform.position * pushForce;
            GetComponent<Rigidbody>().AddForceAtPosition(f, p);
        }
	
	}
}
