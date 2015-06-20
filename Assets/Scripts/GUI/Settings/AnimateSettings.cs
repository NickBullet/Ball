using UnityEngine;
using System.Collections;

public class AnimateSettings : MonoBehaviour 
{
    /*public GameObject soundOn;
    public GameObject soundOff;
    public GameObject languageUa;
    public GameObject languageUK;
    public GameObject languageRus;
    
    public AnimationClip animSound;
    public AnimationClip animLanguage;
    Animation anim;*/
    public static bool settingsEnabled;

	void Start ()
    {
        settingsEnabled = false;
    }
	
    public void OnSettingsOn()
    {
        switch ( settingsEnabled )
        {
            case false: 
                settingsEnabled = true;

                //Enables sound buttons in main menu
                if ( SoundButton.sound == true )
                {
                    SoundButton.imageOff.enabled = true;
                    SoundButton.buttonOff.enabled = true;
                }
                else if (SoundButton.sound == false)
                {
                    SoundButton.imageOn.enabled = true;
                    SoundButton.buttonOn.enabled = true;
                }
                //Enables language buttons in main menu
                if (LanguageButton.langCurrentString == "English")
                {
                    LanguageButton.imageGB.enabled = true;
                    LanguageButton.buttonGB.enabled = true;
                }
                else if (LanguageButton.langCurrentString == "Russian")
                {
                    LanguageButton.imageRU.enabled = true;
                    LanguageButton.buttonRU.enabled = true;
                }
                else if (LanguageButton.langCurrentString == "Ukrainian")
                {
                    LanguageButton.imageUA.enabled = true;
                    LanguageButton.buttonUA.enabled = true;
                }
                Debug.Log ( "true" ); 
                break;

            case true: 
                settingsEnabled = false;

                //Disables sound buttons in main menu
                SoundButton.imageOff.enabled = false;
                SoundButton.buttonOff.enabled = false;
                SoundButton.imageOn.enabled = false;
                SoundButton.buttonOn.enabled = false;
                //Disables language buttons in main menu
                LanguageButton.imageGB.enabled = false;
                LanguageButton.buttonGB.enabled = false;
                LanguageButton.imageRU.enabled = false;
                LanguageButton.buttonRU.enabled = false;
                LanguageButton.imageUA.enabled = false;
                LanguageButton.buttonUA.enabled = false;

                Debug.Log ( "false" ); 
                break;
        }
    }
}
