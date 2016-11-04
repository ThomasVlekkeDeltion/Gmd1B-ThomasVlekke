using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivesText : MonoBehaviour {

    public Text livestext;

    public void ChangeScore(int points)
    {
        GameObject.Find("Manager").GetComponent<Lives>().lives += points;
        livestext.text = GameObject.Find("Manager").GetComponent<Lives>().lives.ToString();
    }
}
