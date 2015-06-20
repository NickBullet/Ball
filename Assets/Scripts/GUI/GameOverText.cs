using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour {

    Text text;

    public static string gameOverText;

	// Use this for initialization
    void Start ()
    {
        text = GetComponent<Text> ();
        gameOverText = "";
    }
	
	// Update is called once per frame
	void Update () 
    {
        text.text = gameOverText;
	}
}