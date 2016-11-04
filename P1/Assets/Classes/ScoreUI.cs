using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {

    public Text scoreText;
    int score;


    public void ChangeScore (int punten)
    {
        score += punten;
        scoreText.text = "Score: "+score;
        
    }


}
