using UnityEngine;
using System.Collections;

public class NewGUI1 : MonoBehaviour {

	public bool isPlayerWinner;
	public TextMesh winnerText;
	
	Rect menuRect = new Rect(0, 250, 120, 146);
	
	void OnGUI(){
		GUI.Box(menuRect, "Game Over Menu");
		GUILayout.BeginArea(menuRect);
			GUILayout.Space (25f);
			if(GUILayout.Button("Main Menu")){
				print("Main Menu pressed");
			}
			if(GUILayout.Button("Replay")){
				print("Replay pressed");
			}
			if(GUILayout.Button("Scores")){
				print("Scores pressed");
			}
		GUILayout.EndArea();
	}
}
