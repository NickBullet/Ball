using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour 
{
    public static Image imageOn;
    public static Image imageOff;
    public static Button buttonOn;
    public static Button buttonOff;

    public static bool sound;

	void Start () 
    {
        sound = true;
        imageOn = GameObject.Find ( "SoundButtonOn" ).GetComponent<Image> ();
        buttonOn = GameObject.Find ( "SoundButtonOn" ).GetComponent<Button> ();
        imageOff = GameObject.Find ( "SoundButtonOff" ).GetComponent<Image> ();
        buttonOff = GameObject.Find ( "SoundButtonOff" ).GetComponent<Button> ();
        DontDestroyOnLoad ( GameObject.FindGameObjectWithTag("Sound"));
	}
	
	public void soundOn()
    {
        if (sound == false)
        {
            sound = true;
            var source = GameObject.FindGameObjectWithTag ( "Sound" );
            source.GetComponent<AudioSource> ().mute = false;
            imageOn.enabled = false;
            buttonOn.enabled = false;
            imageOff.enabled = true;
            buttonOff.enabled = true;
        }
    }

    public void soundOff()
    {
        if (sound == true)
        {
            sound = false;
            var source = GameObject.FindGameObjectWithTag ( "Sound" );
            source.GetComponent<AudioSource> ().mute = true;
            imageOn.enabled = true;
            buttonOn.enabled = true;
            imageOff.enabled = false;
            buttonOff.enabled = false;
        }
    }
}
