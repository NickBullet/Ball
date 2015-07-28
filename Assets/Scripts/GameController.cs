using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
    private GameObject _player;
    public GameObject plane;
    public GameObject coin;
    private Vector3 _playerSpawn;
    private Vector3 _coinSpawn;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;

    public static bool isRightButtonActive;
    public static bool isLeftButtonActive;
    public static int i;
    //public float waveWait;

	void Start () 
    {
        if (SoundButton.sound == false)
        {
            var source = GameObject.FindGameObjectWithTag ( "MainCamera" );
            source.GetComponent<AudioSource> ().mute = true;
        }
        _player = GameObject.FindGameObjectWithTag ( "Player" );
        StartCoroutine ( SpawnWaves () );
	}
	
	// Update is called once per frame
	void Update () 
    {
        if ( Input.GetKeyDown ( KeyCode.R ) )
        {
            Application.LoadLevel ( Application.loadedLevel );
        }
        if ( Input.GetKeyDown ( KeyCode.Escape ) )
        {
            Application.Quit ();
        }
	}

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds ( startWait );
        short ident = 0;
        while ( true )
        {
            for ( i = 0; i < hazardCount; i++ )
            {
                Vector3 spawnPosition = new Vector3 ( Random.Range ( -spawnValues.x, spawnValues.x ), spawnValues.y, spawnValues.z );
                if ( i == 0 && ident == 0 )
                {
                    _playerSpawn = spawnPosition + new Vector3 ( 0.0f, 1.8f, 0.0f );
                    _player.transform.position = _playerSpawn;
                    ident = 1;
                }
                //Quaternion spawnRotation = Quaternion.identity;
                
                Instantiate ( plane, spawnPosition, plane.transform.rotation );
                
                if (Random.Range(0,5)/2 == 0 && i > 0)
                {
                    _coinSpawn = spawnPosition + new Vector3 ( 0.0f, 0.8f, 0.0f );
                    Instantiate ( coin, _coinSpawn, coin.transform.rotation );
                }
                yield return new WaitForSeconds ( spawnWait );
            }
            //yield return new WaitForSeconds ( waveWait );
        }
    }

}
