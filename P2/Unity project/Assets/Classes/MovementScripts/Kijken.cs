using UnityEngine;
using System.Collections;

public class Kijken : MonoBehaviour {

    public Vector3 camRotatie;
    public Vector3 rotatieS;
    public GameObject cam;
    public float speed;
    public float adjustmentsspeed;
    public float minaxis;
    public float maxaxis;

    void Start()
    {

    }



    void Update()
    {

        if (Input.GetKeyDown("o"))
        {
            decreasesen();
        }

        if (Input.GetKeyDown("p"))
        {
            increasesen();
        }

        if (speed < 1)
        {
            speed = 1;
        }

        if (speed < minaxis)
        {
            speed = minaxis;
        }
        if (speed > maxaxis)
        {
            speed = maxaxis;
        }

        rotatieS = rotatieS * Time.deltaTime;
        camRotatie = camRotatie * Time.deltaTime;

        rotatieS.y = Input.GetAxis("Mouse X") * speed;
        camRotatie.x = Input.GetAxis("Mouse Y") * -speed;

        transform.Rotate(rotatieS);
        cam.transform.Rotate(camRotatie);

       // rotatieS.y = Mathf.Clamp(rotatieS.y, -85, 90);
       // transform.rotation = Quaternion.Euler(0, 0, speed);


    }

    public void increasesen()
    {
        speed = speed + adjustmentsspeed;
    }

    public void decreasesen()
    {
        speed = speed - adjustmentsspeed;
    }
}
