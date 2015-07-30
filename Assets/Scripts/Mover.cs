using UnityEngine;

public class Mover : MonoBehaviour {

    public float speed;

	void Start () 
    {

	}
	
	void FixedUpdate () 
    {
        transform.position += Vector3.up * Time.deltaTime * speed;
	}
}
