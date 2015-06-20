using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseHide : MonoBehaviour {

    Image buttonImage;
    Button button;

    void Start()
    {
        buttonImage = GetComponent<Image> ();
        button = GetComponent<Button> ();
    }

	// Update is called once per frame
	void Update () 
    {
	    if (GamePause.paused == true || DestroyByBoundary.isGameOver == true)
        {
            buttonImage.enabled = false;
            button.enabled = false;
        }
        else
        {
            buttonImage.enabled = true;
            button.enabled = true;
        }
	}
}
