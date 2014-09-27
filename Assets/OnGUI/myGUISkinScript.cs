using UnityEngine;
using System.Collections;

public class myGUISkinScript : MonoBehaviour {

	public GUISkin myGUISkin;
	
	void OnGUI(){
		if(OnGUIMenu.menuSelect == 2){
			GUI.skin = myGUISkin;
			Rect myRect = new Rect(150, 0, 110, 290);
			GUILayout.BeginArea(myRect);
			GUILayout.Label("Custom GUI");
			if(GUILayout.Button("Custom Button")){}
			GUILayout.Box("Custom Box");
			GUILayout.EndArea();
		}
	}
}
