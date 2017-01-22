using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public Vector3 links;
    public float hor;
    public float ver;
   // public float hor2;
   // public float ver2;
    public float accel;


    void Start()
    {

    }


    void FixedUpdate()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        links.x = hor;
        links.z = ver;

        transform.Translate(links * Time.deltaTime * accel);


    }
    void OnCollisionEnter(Collision c)
    {

    }
}
