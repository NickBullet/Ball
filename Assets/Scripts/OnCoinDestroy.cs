using UnityEngine;
using System.Collections;

public class OnCoinDestroy : MonoBehaviour 
{
    private GameObject _player;

	// Use this for initialization
	void Start () 
    {
        _player = GameObject.FindGameObjectWithTag ( "Player" );
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) 
    {
	    if (other.gameObject == _player)
        {
            Destroy ( this.gameObject );
            scoreText.score += 1;
        }
	}
}
