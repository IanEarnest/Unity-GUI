using UnityEngine;
using System.Collections;

public class LevelBack : MonoBehaviour {

	void OnGUI(){
		GUILayout.BeginArea (new Rect (0, 150, 100, 300));
		if(GUILayout.Button("Levels menu")){
			Application.LoadLevel("Loading Levels");
		}
		if(GUILayout.Button("Level 1")){
			if(Application.CanStreamedLevelBeLoaded("Level 1")){
				Application.LoadLevel("Level 1");
			}
		}
		if(GUILayout.Button("Level 2")){
			if(Application.CanStreamedLevelBeLoaded("Level 2")){
				Application.LoadLevel("Level 2");
			}
		}
		if(GUILayout.Button("Level 3")){
			if(Application.CanStreamedLevelBeLoaded("Level 3")){
				Application.LoadLevel("Level 3");
			}
		}
		GUILayout.EndArea ();
	}
}
