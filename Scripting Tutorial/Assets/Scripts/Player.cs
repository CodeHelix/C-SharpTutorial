using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    private Transform myTransform;
    public int playerSpeed = 5;

	// Use this for initialization
	void Start () 
    {
        myTransform = transform;

	    // Spawn point       x   y   z
        // Postion to be at -3, -3, -1

        myTransform.position = new Vector3(-3, -3, -1);

	}
	
	// Update is called once per frame
	void Update () 
    {
	    // Move the player left and right

        myTransform.Translate(Vector3.right * playerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
	}
}
