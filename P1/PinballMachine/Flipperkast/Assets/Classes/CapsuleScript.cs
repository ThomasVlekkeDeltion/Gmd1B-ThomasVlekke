using UnityEngine;
using System.Collections;

public class CapsuleScript : MonoBehaviour {

    public GameObject cylinder;
    public GameObject prefab;


    void OnCollisionEnter()
    {
        Destroy(gameObject);
        GameObject pinball = (GameObject)Instantiate(prefab, cylinder.GetComponent<Transform>().position, cylinder.GetComponent<Transform>().rotation);
        
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
