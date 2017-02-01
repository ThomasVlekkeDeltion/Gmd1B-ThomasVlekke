using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public Vector3 links;
    public float hor;
    public float ver;
    public float accel;


    void Start()
    {

    }


    void FixedUpdate()
    {
        //de float "hor" word de input axis "Horizontal" en hetzelfde geldt voor "ver" met "Vertical"
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        // de Vector3 "links" zn x as word "hor" en het z as word "ver"
        links.x = hor;
        links.z = ver;

        // de variabele die word gegeven in unity * Time.deltaTime (zodate het per seconde gaat en niet per frame) * de Vector3 "links" 
        transform.Translate(links * Time.deltaTime * accel);


    }
    
}
