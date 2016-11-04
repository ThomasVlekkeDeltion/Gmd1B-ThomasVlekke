using UnityEngine;
using System.Collections;

public class ScoreTekst : MonoBehaviour {

    public ScoreUI scoreScript;
    public int punten;

    void OnCollisionEnter()
    {
        scoreScript.ChangeScore(punten);

    }
}
