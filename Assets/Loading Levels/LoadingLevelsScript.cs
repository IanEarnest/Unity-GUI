using UnityEngine;
using System.Collections;

public class LoadingLevelsScript : MonoBehaviour {
	
	/*
    Edit - Project Settings - Player, Streaming - First Streamed Level = 1
     */

	string level1Name = "Level 1";
	string level1Load = "";
	bool canLevel1Load = false;
	float level1LoadPercentage = 0;

	string level2Name = "Level 2";
	string level2Load = "";
	bool canLevel2Load = false;
	float level2LoadPercentage = 0;

	string level3Name = "Level 3";
	string level3Load = "";
	bool canLevel3Load = false;
	float level3LoadPercentage = 0;
	
	void Update () {
		// Stream progress level 1
		if(Application.GetStreamProgressForLevel(level1Name) == 1) {
			level1Load = level1Name + " loaded.";
		} else {
			level1LoadPercentage = Application.GetStreamProgressForLevel(level1Name) * 100;
			level1Load = level1Name + " loading... " + level1LoadPercentage.ToString();
		}
		
		// Stream progress level 2
		if(Application.GetStreamProgressForLevel(level2Name) == 1) {
			level2Load = level2Name + " loaded.";
		} else {
			level2LoadPercentage = Application.GetStreamProgressForLevel(level2Name) * 100;
			level2Load = level2Name + " loading... " + level2LoadPercentage.ToString();
		}
		
		// Stream progress level 3
		if(Application.GetStreamProgressForLevel(level3Name) == 1) {
			level3Load = level3Name + " loaded.";
		} else {
			level3LoadPercentage = Application.GetStreamProgressForLevel(level3Name) * 100;
			level3Load = level3Name + " loading... " + level3LoadPercentage.ToString();
		}
		
		
		// Can level be loaded
		canLevel1Load = Application.CanStreamedLevelBeLoaded (level1Name);
		canLevel2Load = Application.CanStreamedLevelBeLoaded (level2Name);
		canLevel3Load = Application.CanStreamedLevelBeLoaded (level3Name);
	}
	
	void OnGUI(){
		GUILayout.BeginArea(new Rect(0, 25, 300, 500));
		GUILayout.Label ("Loading levels...");
		GUILayout.Label (level1Name + " load: " + level1Load + 
		                 "\nCan " + level1Name + " load? " + canLevel1Load);
		
		GUILayout.Label (level2Name + " load: " + level2Load + 
		                 "\nCan " + level2Name + " load? " + canLevel2Load);
		
		GUILayout.Label (level3Name + " load: " + level3Load + 
		                 "\nCan " + level3Name + " load? " + canLevel3Load);
		GUILayout.EndArea();
	}
}
