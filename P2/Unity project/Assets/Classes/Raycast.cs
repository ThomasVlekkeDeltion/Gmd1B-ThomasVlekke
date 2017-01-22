using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

    private RaycastHit hit;


    void Start()
    {

    }


    void Update()
    {
      
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.DrawRay(transform.position, transform.forward*100, Color.blue);
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
            {
                if (hit.transform.tag == "vernietigen")
                {
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}
