using UnityEngine;
using System.Collections;

public class CamerasMenu : MonoBehaviour {

	Rect guiRect = new Rect(Screen.width-100, Screen.height/2-75, 100, 150);

	void OnGUI(){
		GUILayout.BeginArea (guiRect);
			GUILayout.Label ("Camera Select");
			if(GUILayout.Button("Main Camera")){
				CameraSwitch.activeCamera = 1;
			}
			if(GUILayout.Button("First Person")){
				CameraSwitch.activeCamera = 2;
			}
			if(GUILayout.Button("Third Person")){
				CameraSwitch.activeCamera = 3;
			}
		GUILayout.EndArea ();
	}
}
