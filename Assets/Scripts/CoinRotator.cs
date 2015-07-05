using UnityEngine;
using System.Collections;

public class CoinRotator : MonoBehaviour {

	void Update () 
    {
        transform.Rotate ( new Vector3 ( 90, 0.0f, 0.0f ) * Time.deltaTime );
	}
}
