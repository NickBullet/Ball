using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanceAfterDeathText : MonoBehaviour {

    public static Text deathText;

    public static string deathDistance;
    // Use this for initialization
    void Start ()
    {
        deathText = GetComponent<Text> ();
        deathText.enabled = false;
    }

    // Update is called once per frame
    void Update ()
    {
        deathText.text = deathDistance;
        if ( DestroyByBoundary.isGameOver == true )
        {
            deathText.enabled = true;
        }
    }
}
