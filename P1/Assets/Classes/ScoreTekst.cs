using UnityEngine;
using System.Collections;

public class ScoreTekst : MonoBehaviour {

    public ScoreUI scoreScript;
    public int punten;

    void OnCollisionEnter()
    {
        //Hier veranderd het script de punten (via een empty GameObject genaamd "Manager"
        scoreScript.ChangeScore(punten);

    }
}
