using UnityEngine;
using System.Collections;

public class Deathzone : MonoBehaviour {

    public Lives gameDataScript;

	void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);
        gameDataScript.lives += -1;
        GameObject.Find("BallSpawner").GetComponent<BallSpawn>().ball = false;
    }
    
}
