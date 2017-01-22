using UnityEngine;
using System.Collections;

public class WapenRotatie : MonoBehaviour {

    public float rotspeed;
    public Vector3 rot;
	
	void Start () {
	
	}
	
	
	void Update () {
        // dit is gewoon een script om het wapen te laten draaien
        rot.y = rotspeed;
        transform.Rotate(rot);
	
	}
}
