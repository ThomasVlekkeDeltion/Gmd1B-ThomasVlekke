using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

    private RaycastHit hit;


    void Start()
    {

    }


    void Update()
    {
      //als de linker muis knop word ingedrukt moet er een ray komen en als deze ray iets raakt checkt die of wat die raakt een tag heeft met de naam "vernietigen" en zo ja, dan vernietigd hij het object wat hij raakt (het object met "vernietigen" als tag). Ook word er nu in unity een blauwe lijn gemaakt om te kijken of het werkte (hoe ver de ray kwam etc.). Als de tag "wapen" is dan moet een bool van een list op het object op true waardoor het object een child word van de Player.
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.DrawRay(transform.position, transform.forward*100, Color.blue);
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
            {
                if (hit.transform.tag == "vernietigen")
                {
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.tag == "wapen")
                {
                    GameObject.Find("WeaponDing").GetComponent<WapenRotatie>().rotatie [0] = true;
                }
            }
        }
    }
}
