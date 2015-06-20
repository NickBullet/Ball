using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LanguageButton : MonoBehaviour {

    string[] language = new string[3];
    public GameObject langGB;
    public GameObject langRU;
    public GameObject langUA;

    public static string langCurrentString;
    int langNum;

    public static Image imageGB;
    public static Button buttonGB;
    public static Image imageRU;
    public static Button buttonRU;
    public static Image imageUA;
    public static Button buttonUA;

	void Start () 
    {
        imageGB = langGB.GetComponent<Image> ();
        buttonGB = langGB.GetComponent<Button> ();

        imageRU = langRU.GetComponent<Image> ();
        buttonRU = langRU.GetComponent<Button> ();

        imageUA = langUA.GetComponent<Image> ();
        buttonUA = langUA.GetComponent<Button> ();

        language[0] = "English";
        language[1] = "Russian";
        language[2] = "Ukrainian";

        langCurrentString = language[0];
        langNum = 0;
	}

    public void Click()
    {
        if ( langNum < 2 )
        {
            langNum += 1;
            langCurrentString = language[langNum];
        }
        else if (langNum == 2)
        {
            langCurrentString = language[0];
            langNum = 0;
        }

        if ( langCurrentString == language[0])
        {
            imageGB.enabled = true;
            buttonGB.enabled = true;

            imageRU.enabled = false;
            buttonRU.enabled = false;
            imageUA.enabled = false;
            buttonUA.enabled = false;
        }
        if (langCurrentString == language[1])
        {
            imageRU.enabled = true;
            buttonRU.enabled = true;

            imageGB.enabled = false;
            buttonGB.enabled = false;
            imageUA.enabled = false;
            buttonUA.enabled = false;
        }
        if (langCurrentString == language[2])
        {
            imageUA.enabled = true;
            buttonUA.enabled = true;

            imageGB.enabled = false;
            buttonGB.enabled = false;
            imageRU.enabled = false;
            buttonRU.enabled = false;
        }
    }
}
