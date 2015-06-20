using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float speed;

	void Start () 
    {

	}
	
	void Update () 
    {

        transform.position += Vector3.up * Time.deltaTime * speed;

	}
}
