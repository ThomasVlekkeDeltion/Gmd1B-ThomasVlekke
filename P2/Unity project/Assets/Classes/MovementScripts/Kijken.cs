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
        //als "o" word ingedrukt moet decreasesen(); worden uitgevoerd
        if (Input.GetKeyDown("o"))
        {
            decreasesen();
        }

        //als "p" word ingedrukt moet increasesen (); worden uitgevoerd
        if (Input.GetKeyDown("p"))
        {
            increasesen();
        }

        //als 'speed' lager is dan 1 dan is speed 1
        if (speed < 1)
        {
            speed = 1;
        }

        //als 'speed' lager is dan 'minaxis' dan word 'speed' 'minaxis'
        if (speed < minaxis)
        {
            speed = minaxis;
        }

        //als 'speed' groter is als 'maxaxis' dan moet 'speed, 'maxaxis' worden
        if (speed > maxaxis)
        {
            speed = maxaxis;
        }

        // de Vector3 'rotatieS = rotatieS * Time.deltaTime'
        // en de Vector3 'camRotatie = camRotatie * Time.deltaTime
        rotatieS = rotatieS * Time.deltaTime;
        camRotatie = camRotatie * Time.deltaTime;

        //het y as van rotatieS en de camRotatie x as worden de y en x as * speed of x -speed van de muis x en y as
        rotatieS.y = Input.GetAxis("Mouse X") * speed;
        camRotatie.x = Input.GetAxis("Mouse Y") * -speed;

        transform.Rotate(rotatieS);
        cam.transform.Rotate(camRotatie);

        // hier probeerde ik met Mathf.Clamp te werken maar dit lukte helaas niet
       // rotatieS.y = Mathf.Clamp(rotatieS.y, -85, 90);
       // transform.rotation = Quaternion.Euler(0, 0, speed);


    }
    //hiermee kan je de sensitivity aanpassen van het kijken door middel van wat er in het begin van deze class staat ("p" of "o" indrukken)
    public void increasesen()
    {
        speed = speed + adjustmentsspeed;
    }

    public void decreasesen()
    {
        speed = speed - adjustmentsspeed;
    }
}
