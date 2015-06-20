using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ContinueHide : MonoBehaviour 
{

    Image hideImage;
    Text hideText;

	// Use this for initialization
	void Start () 
    {
        hideImage = GetComponent<Image> ();
        hideText = GetComponentInChildren<Text> ();
        hideImage.enabled = false;
        hideText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (GamePause.paused == true )
        {
            hideImage.enabled = true;
            hideText.enabled = true;
        }
        if ( GamePause.paused == false && DestroyByBoundary.isGameOver == false )
        {
            hideImage.enabled = false;
            hideText.enabled = false;
        }
	}
}
