using UnityEngine;
using System.Collections;

public class GUIFontChange1 : MonoBehaviour {

	void OnGUI () {
		if(GUI.Button(new Rect(0,100,120,50),"Button")){
			print("hi");
		}
		GUI.Box(new Rect(0,150,120,50),"Box");
		GUI.Label(new Rect(0,200,120,50),"Label");
	}
}