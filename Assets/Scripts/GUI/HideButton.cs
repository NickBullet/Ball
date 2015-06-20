using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HideButton : MonoBehaviour 
{

    Image hideImage;
    Text hideText;

	// Use this for initialization
	void Start () 
    {
        hideImage = GetComponent<Image>();
        hideText = GetComponentInChildren<Text> ();
        hideText.enabled = false;
        hideImage.enabled = false;

	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (DestroyByBoundary.isGameOver == true)
        {
            hideImage.enabled = true;
            hideText.enabled = true;
        }
        if (GamePause.paused == true )
        {
            hideImage.enabled = true;
            hideText.enabled = true;
        }
        if (GamePause.paused == false && DestroyByBoundary.isGameOver == false)
        {
            hideImage.enabled = false;
            hideText.enabled = false;
        }
	}
}
