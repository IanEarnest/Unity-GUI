using UnityEngine;
using System.Collections;

public class GUIFontChange1 : MonoBehaviour {

	void OnGUI () {
		if(OnGUIMenu.menuSelect == 1){
			if(GUI.Button(new Rect(0,0,120,50),"Button")){
				print("hi");
			}
			GUI.Box(new Rect(0,50,120,50),"Box");
			GUI.Label(new Rect(0,100,120,50),"Label");


			Rect myRect = new Rect(150, 0, 110, 290);
			GUILayout.BeginArea(myRect);
			GUILayout.Label("Custom GUI");
			if(GUILayout.Button("Custom Button")){}
			GUILayout.Box("Custom Box");
			GUILayout.EndArea();
		}
	}
}