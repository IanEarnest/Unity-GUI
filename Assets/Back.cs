using UnityEngine;
using System; // system is only used on standalone.
using System.Collections;

public class Back : MonoBehaviour {

	Rect backRect = new Rect(Screen.width-80, Screen.height-50, 80, 50);

	public GameObject welcomeScript;
	static bool isActive;

	void Start(){
		welcomeScript = new GameObject("Script1");
		welcomeScript.AddComponent ("Welcome");
		welcomeScript.SetActive (isActive);
	}



	void OnGUI(){
		string menuText = "";
		if (!isActive) {
			menuText = "Show Menu";
		}
		if (isActive) {
			menuText = "Hide Menu";
		}

		GUI.BeginGroup (backRect);
			if(GUILayout.Button("Exit level")){
				Application.LoadLevel("Welcome");
			}
			if(GUILayout.Button(menuText)){
				isActive = !isActive;
				welcomeScript.SetActive (isActive);
			}
		GUI.EndGroup ();
	}
}
