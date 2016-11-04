using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivesText : MonoBehaviour {

    public Text livestext;

    public void ChangeScore(int points)
    {
        //Hier pak ik de int van het script lives en zeg ik dat lives = lives + points (points = 3)
        GameObject.Find("Manager").GetComponent<Lives>().lives += points;
        //Hier verander ik "lives" naar een string
        livestext.text = GameObject.Find("Manager").GetComponent<Lives>().lives.ToString();

    }
}
