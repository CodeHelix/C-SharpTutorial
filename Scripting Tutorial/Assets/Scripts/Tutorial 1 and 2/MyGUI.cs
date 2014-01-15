using UnityEngine;
using System.Collections;

public class MyGUI : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnGUI()
    {
        //Make a background for the button

        GUI.Box(new Rect(Screen.width / 2 -50, Screen.height / 2 - 100, 100, 200), "Menu");

        // Make a button.
        // Be able to click that button
        // If they click it, return inventory screen.

        if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 -25, 80, 20), "Inventory"))
        {
            Debug.Log("Your inventory opens");
            //Application.LoadLevel(1);
        }  
    }
}
