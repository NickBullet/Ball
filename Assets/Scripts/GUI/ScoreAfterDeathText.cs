using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreAfterDeathText : MonoBehaviour 
{
    public static Text deathText;

    public static string deathScore;
	// Use this for initialization
	void Start () 
    {
        deathText = GetComponent<Text> ();
        deathText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        deathText.text = deathScore;
        if ( DestroyByBoundary.isGameOver == true )
        {
            deathText.enabled = true;
        }
	}
}