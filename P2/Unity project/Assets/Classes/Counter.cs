using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour {

    public float timer;

	
	void Start () {
	
	}
	
	
	void Update () {

        timer += Time.deltaTime;

        if(timer > 10)
        {
            Destroy(gameObject);
        }

	}
}
