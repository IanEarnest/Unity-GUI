using UnityEngine;
using System.Collections;

public class myGUISkinScript : MonoBehaviour {

	public GUISkin myGUISkin;
	
	void OnGUI(){
		GUI.skin = myGUISkin;
		Rect myRect = new Rect(430, 0, 110, 290);
		GUILayout.BeginArea(myRect);
		GUILayout.Label("Custom GUI");
		if(GUILayout.Button("Custom Button")){}
		GUILayout.Box("Custom Box");
		GUILayout.EndArea();
	}
}
