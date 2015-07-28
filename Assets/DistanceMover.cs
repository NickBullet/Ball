using UnityEngine;
using System.Collections;
using System;

public class DistanceMover : MonoBehaviour 
{
    public static float distFromPlayer;
    GameObject player;
	void Start () 
    {
        distFromPlayer = 0;
        player = GameObject.FindGameObjectWithTag ( "Player" );
        
	}

    void Update ()
    {
        try
        {
            if ( DestroyByBoundary.isGameOver == false )
            {
                distFromPlayer = Vector3.Distance ( player.transform.position, transform.position );
            }
        }
        catch (Exception)
        {
            Debug.LogWarning ( "Ball was destroyed or not found. (DistanceMover.cs)" );
        }
    }
}
