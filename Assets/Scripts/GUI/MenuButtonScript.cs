using UnityEngine;
using System.Collections;

public class MenuButtonScript : MonoBehaviour 
{
    void Start ()
    {
        if ( SoundButton.sound == false )
        {
            var source = GameObject.FindGameObjectWithTag ( "Sound" );
            source.GetComponent<AudioSource> ().Play ();
        }
    }

	public void OnGameButton () 
    {
        Application.LoadLevel ( 1 );
        DestroyByBoundary.isGameOver = false;
        GamePause.paused = false;
        Time.timeScale = 1;
	}

    public void OnRestartButton ()
    {
        Application.LoadLevel ( 1 );
        DestroyByBoundary.isGameOver = false;
        GamePause.paused = false;
        Time.timeScale = 1;
    }

    public void OnMenuButton()
    {
        Application.LoadLevel ( 0 );
    }

    public void OnExitButton ()
    {
        Application.Quit ();
    }

}
