using UnityEngine;
using System.Collections;

public class GUIFontChange2 : MonoBehaviour {

	// Set custom font sizes.
	int buttonFontSize = 5;
	int boxFontSize = 20;
	int labelFontSize = 30;

	public GUISkin myGUISkin;

	void OnGUI () {
		myGUISkin.button.fontSize = buttonFontSize;
		myGUISkin.box.fontSize = boxFontSize;
		myGUISkin.label.fontSize = labelFontSize;
		GUI.skin = myGUISkin;


		if(GUI.Button(new Rect(125,100,120,50),"Button")){
			print("hi");
		}
		GUI.Box(new Rect(125,150,120,50),"Box");
		GUI.Label(new Rect(125,200,120,50),"Label");
	}
}