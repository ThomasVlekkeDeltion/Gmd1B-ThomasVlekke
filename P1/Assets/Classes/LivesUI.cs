using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour {

    public int points;
    public LivesText livesScript;
	
    void OnCollisionEnter()
    {
        livesScript.ChangeScore(points);
    }
}
