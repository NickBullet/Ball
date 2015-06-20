using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverImageHide : MonoBehaviour
{
    Image image;

	// Use this for initialization
	void Start ()
    {
        image = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if ( DestroyByBoundary.isGameOver == false )
        {
            image.enabled = false;
        }
        else
        {
            image.enabled = true;
        }
	}
}
