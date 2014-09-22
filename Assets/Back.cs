using UnityEngine;
using System; // system is only used on standalone.
using System.Collections;

public class Back : MonoBehaviour {

	Rect backRect = new Rect(Screen.width-70, Screen.height-30, 70, 30);
	Rect backRect2 = new Rect(Screen.width-70, Screen.height-60, 70, 30);

	public GameObject welcomeScript;
	static bool isActive;

	void Start(){
		welcomeScript = new GameObject("Script1");
		welcomeScript.AddComponent ("Welcome");
		welcomeScript.SetActive (isActive);
	}



	void OnGUI(){
		if(GUI.Button(backRect, "Exit level")){
			Application.LoadLevel("Welcome");
		}
		if(GUI.Button(backRect2, "Show menu")){
			isActive = !isActive;
			welcomeScript.SetActive (isActive);
		}
	}
}
