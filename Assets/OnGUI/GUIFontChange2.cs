using UnityEngine;
using System.Collections;

public class GUIFontChange2 : MonoBehaviour {

	// Set custom font sizes.
	int buttonFontSize = 5;
	int boxFontSize = 20;
	int labelFontSize = 35;

	public GUISkin myGUISkin;

	void OnGUI () {		
		GUI.skin = myGUISkin;
		GUI.skin.button.fontSize = buttonFontSize;
		GUI.skin.box.fontSize = boxFontSize;
		GUI.skin.label.fontSize = labelFontSize;

		if(GUI.Button(new Rect(125,100,120,50),"Button")){
			print("hi");
		}
		GUI.Box(new Rect(125,150,120,50),"Box");
		GUI.Label(new Rect(125,200,120,50),"Label");
	}
}