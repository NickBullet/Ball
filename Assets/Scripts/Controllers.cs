using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System.Collections;

public class Controllers : MonoBehaviour
{

    float moveHorizontal;
    Image img;

    void Start ()
    {
        img = GetComponent<Image> ();
    }

    void Update ()
    {
        if ( GamePause.paused == true || DestroyByBoundary.isGameOver == true)
        {
            img.enabled = false;
        }
        else
        {
            img.enabled = true;
        }
    }

    public void OnLeftTouch ()
    {
        SphereMove.moveHorizontal = -1.0f;
    }

    public void OnRightTouch ()
    {
        SphereMove.moveHorizontal = 1.0f;
    }

    public void OnStop ()
    {
        SphereMove.moveHorizontal = 0.0f;
    }
}
