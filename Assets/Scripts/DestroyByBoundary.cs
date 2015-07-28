using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour 
{
    GameOverText gameOver;
    public static bool isGameOver = false;
    void OnTriggerExit ( Collider other )
    {
       if ( other.gameObject == GameObject.FindGameObjectWithTag ( "Player" ) )
       {
           GameOverText.gameOverText = "Game Over!";
           isGameOver = true;
       }
       Destroy ( other.gameObject );
    }

}
