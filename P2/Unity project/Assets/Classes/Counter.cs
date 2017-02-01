using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour {

    public float timer;
    public GameObject canvas;

	
	void Start () {
	
	}
	
	
	void Update () {

        if (GameObject.Find("Main Camera").GetComponent<Raycast>().vernietigd == true)
        {
            timer += Time.deltaTime;

            if (timer > 8)
            {
                Destroy(gameObject);
                timer = 0;
                Instantiate(canvas);
                if (timer > 5)
                {
                    Destroy(canvas);
                }
            }
        }
        

	}
}
