using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {

    public Text scoreText;
    int score;


    public void ChangeScore (int punten)
    {
        //Hier zeg ik dat score = score + punten en dat hij Score:  + score (is in het begin 0 maar word meer als er punten bij komen) moet laten zien (in dit geval in een canvas)
        score += punten;
        scoreText.text = "Score: "+score;
        
    }


}
