using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanceText : MonoBehaviour {

    public static int distance;

    Text text;

	void Start () 
    {
        text = GetComponent<Text> ();
        distance = 0;
	}
	
	void Update () 
    {
        text.text = "Distance: " + (Mathf.Round(DistanceMover.distFromPlayer - 10));
        if ( DestroyByBoundary.isGameOver == true )
        {
            DistanceAfterDeathText.deathDistance = text.text;
            text.enabled = false;
        }
	}
}
