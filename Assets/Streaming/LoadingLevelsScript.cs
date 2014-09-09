using UnityEngine;
using System.Collections;

public class LoadingLevelsScript : MonoBehaviour {

	public float Level1Percentage = 0;
	public float Level2Percentage = 0;
	public float Level3Percentage = 0;
	public float newLevel1Percentage = 0;
	public float newLevel2Percentage = 0;
	public float newLevel3Percentage = 0;

	// Test of loading
	public float percentageLoaded = 0;
	public float percentageLoaded2 = 0;
	public float percentageLoaded3 = 0;
	bool loaded;
	bool loaded2;
	bool loaded3;


	void Update() {
		if (Application.GetStreamProgressForLevel("Level 1") == 1)
		if(!guiText.text.Contains("Level 1 has been fully streamed!")){
			guiText.text += "Level 1 has been fully streamed!";
		}
		else {
			if(!loaded){
				percentageLoaded = Application.GetStreamProgressForLevel("Level 1") * 100;
				guiText.text += " " + percentageLoaded.ToString();
				//Resources.Load("20mb image");
				loaded = true;
			}
		}
		
		if (Application.GetStreamProgressForLevel("Level 2") == 1)
		if(!guiText.text.Contains("Level 2 has been fully streamed!")){
			guiText.text += "\nLevel 2 has been fully streamed!";
		}
		else {
			if(!loaded2){
				percentageLoaded = Application.GetStreamProgressForLevel("Level 2") * 100;
				guiText.text += " " + percentageLoaded.ToString();
				loaded2 = true;
			}
		}
		
		if (Application.GetStreamProgressForLevel("Level 3") == 1)
		if(!guiText.text.Contains("Level 3 has been fully streamed!")){
			guiText.text += "\nLevel 3 has been fully streamed!";
		}
		else {
			if(!loaded3){
				percentageLoaded = Application.GetStreamProgressForLevel("Level 3") * 100;
				guiText.text += " " + percentageLoaded.ToString();
				loaded3 = true;
			}
		}
	}

	void OnGUI(){
		//loading bar progress here
		if (Application.GetStreamProgressForLevel("Level 1") == 1){
			GUILayout.Label("Level 1 Done!");
		}
		else {
			Level1Percentage = Application.GetStreamProgressForLevel("Level 1") * 100;
			GUILayout.Label("Level 1: " + Level1Percentage.ToString());
		}
		
		if (Application.GetStreamProgressForLevel("Level 2") == 1){
			GUILayout.Label("Level 2 Done!");
		}
		else {
			Level2Percentage = Application.GetStreamProgressForLevel("Level 2") * 100;
			GUILayout.Label("Level 2: " + Level2Percentage.ToString());
		}
		
		if (Application.GetStreamProgressForLevel("Level 3") == 1){
			GUILayout.Label("Level 3 Done!");
		}
		else {
			Level3Percentage = Application.GetStreamProgressForLevel("Level 3") * 100;
			GUILayout.Label("Level 3: " + Level3Percentage.ToString());
		}
		//////////////////////////////////////////////////////////////////////////////////////////////////
		
		//Stage 2
		if (Application.CanStreamedLevelBeLoaded("Level 1"))
			GUILayout.Label("New Level 1: " + newLevel1Percentage.ToString());
		if (Application.CanStreamedLevelBeLoaded("Level 2"))
			GUILayout.Label("New Level 2: " + newLevel2Percentage.ToString());
		if (Application.CanStreamedLevelBeLoaded("Level 3"))
			GUILayout.Label("New Level 3: " + newLevel3Percentage.ToString());
		
		
		/////////////////////////////////////////////////////////////////////////////////////////////////
		
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
	}
}
