using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GamePause : MonoBehaviour {

    public static bool paused = false;

	// Update is called once per frame
	public void Pause()
    {
        if ( paused == false )
        {
            Time.timeScale = 0;
            paused = true;
        }
    }

    public void Continue()
    {
        if ( paused == true )
        {
            Time.timeScale = 1;
            paused = false;
        }
    }
    void Update () 
    {

	}
}
