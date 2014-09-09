using UnityEngine;
using System; // system is only used on standalone.
using System.Collections;

public class Back : MonoBehaviour {

	Rect backRect = new Rect(Screen.width-70, Screen.height-30, 70, 30);

	
	void OnGUI(){

		if(GUI.Button(backRect, "Back")){
			Application.LoadLevel("Welcome");
		}
	}
}
