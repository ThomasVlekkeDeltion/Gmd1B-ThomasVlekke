using UnityEngine;
using System.Collections;

public class Deathzone : MonoBehaviour {

    public Lives gameDataScript;

	void OnCollisionEnter(Collision c)
    {
        //Ik destroy hetgene wat collision maakt met het object waar dit script op staat en ik trek ook gelijk één af van de levens
        Destroy(c.gameObject);
        gameDataScript.lives += -1;
        //ik zeg hier dat het mogelijk is om een bal te spawnen nadat er collision is gemaakt
        GameObject.Find("BallSpawner").GetComponent<BallSpawn>().ball = false;
    }
    
}
