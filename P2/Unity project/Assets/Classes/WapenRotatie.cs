using UnityEngine;
using System.Collections;

public class WapenRotatie : MonoBehaviour {

    public float rotspeed;
    public Vector3 rot;
	
	void Start () {
	
	}
	
	
	void Update () {

        rot.y = rotspeed;
        transform.Rotate(rot);
	
	}
}
