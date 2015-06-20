using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreText : MonoBehaviour 
{

    public static int score;

    Text text;

	// Use this for initialization
	void Start () 
    {
        text = GetComponent<Text>();
        score = 0;
	}
	
	// Update is called once per frame
	void Update () 
    {
        text.text = "Score: " + score;
        if ( DestroyByBoundary.isGameOver == true )
        {
            ScoreAfterDeathText.deathScore = "Score: " + score;
            text.enabled = false;
        }
	}
}