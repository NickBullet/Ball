using UnityEngine;
using System.Collections;

public class SphereMove : MonoBehaviour 
{
    public float grav;
    public static float speed = 10;

    private Rigidbody rb;

    public static float moveHorizontal;
    //public Texture btnTexture;
	void Start () 
    {
        rb = GetComponent<Rigidbody> ();
        Physics.gravity = new Vector3 ( 0.0f, grav, 0.0f );
	}

    /*void FixedUpdate()
    {
        Vector3 movement = new Vector3 ( moveHorizontal, 0.0f, 0.0f );

        rb.AddForce ( movement * speed );
    }*/

    void FixedUpdate()
    {
        Vector3 movement = new Vector3 ( moveHorizontal, 0.0f, 0.0f );
        rb.velocity = movement * speed;
    }
	
    // Update is called once per frame
	/*void FixedUpdate () 
    {
        //float moveHorizontal = Input.GetAxis ( "Horizontal" );
        
        Vector3 movement = new Vector3 ( moveHorizontal, 0.0f, 0.0f );
        GetComponent<Rigidbody> ().velocity = movement * speed;
        Physics.gravity = new Vector3 ( 0.0f, grav, 0.0f );
        //moveHorizontal = 0.0f;
	}*/
}
