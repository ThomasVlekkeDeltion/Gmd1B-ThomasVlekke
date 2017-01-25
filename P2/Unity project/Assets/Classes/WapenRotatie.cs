using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WapenRotatie : MonoBehaviour {

    public float rotspeed;
    public Vector3 rot;
    public List<bool> rotatie = new List<bool>();

	
	void Start () {
	
	}
	
	
	void Update () {
        // dit is gewoon een script om het wapen te laten draaien
        rot.y = rotspeed;
        transform.Rotate(rot);
	
	}
}
