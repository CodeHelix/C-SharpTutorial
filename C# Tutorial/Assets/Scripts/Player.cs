using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float playerSpeed = 5.0f;

	// Use this for initialization
	void Start () 
    {
	    //Player Spawn Point

        //This is where our player will start when the game is played.

        //player == game objecy. Game object == transform!

        transform.position = new Vector3(-2, 3, 0);
	}
	
	// Update is called once per frame
	void Update () 
    {
		// player to move left/right/up/down
		//player (gameobject) aka transform to move when I press the arrow keys

		transform.Translate (Vector3.right * Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime);

		transform.Translate (Vector3.up * Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);
	}
}