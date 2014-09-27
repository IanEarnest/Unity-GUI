using UnityEngine;
using System.Collections;

public class LevelBack : MonoBehaviour {

	void OnGUI(){
		GUILayout.BeginArea (new Rect (0, 50, 100, 300));
		if(GUILayout.Button("Levels menu")){
			Application.LoadLevel("Loading Levels");
		}
		GUILayout.EndArea ();
	}
}
