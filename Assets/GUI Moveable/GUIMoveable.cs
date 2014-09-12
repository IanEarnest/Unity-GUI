using UnityEngine;
using System.Collections;

public class GUIMoveable : MonoBehaviour {
	
	Rect window1Rect;
	Rect window2Rect;
	Rect window3Rect;
	Rect guiButton1GroupRect;
	Rect guiButton1Rect;
	Rect guiButton2Rect;
	Rect guiButton3Rect;
	Rect guiButton4Rect;
	Rect guiButton5Rect;
	Rect buttons1Rect;
	Rect buttons2Rect;
	Rect buttons2Rect2;
	bool isMoveable;
	bool isMoveable2;

	void Start(){
		resetGUI ();
	}

	void OnGUI(){
		if(GUI.Button(buttons1Rect, "Reset")){
			resetGUI();
		}
		GUI.BeginGroup (guiButton1GroupRect);
			guiButtons1 ();
		GUI.EndGroup ();

		if(GUI.Button(guiButton4Rect, "GUIB4")){
			print ("GUIButton4");
		}

		if(GUI.Button(guiButton5Rect, "GUIB5")){
			print ("GUIButton5");
		}

		if(isMoveable == false){
			if(GUI.Button(buttons2Rect, "Make moveable")){
				isMoveable = true;
			}
		}
		else {
			// GUILayout.Window(0 - is used for Welcome menu
			window1Rect = GUILayout.Window(1, window1Rect, window1Function, "Move 1");
			window2Rect = GUILayout.Window(2, window2Rect, window2Function, "Move 2");
			window3Rect = GUILayout.Window(3, window3Rect, window3Function, "Move 3");
			if(GUI.Button(buttons2Rect, "Make unmoveable")){
				isMoveable = false;
				isMoveable2 = false;
				guiButton1GroupRect.x = window1Rect.x;
				guiButton1GroupRect.y = window1Rect.y;
				//guiButton2Rect.x = window1Rect.x;
				//guiButton2Rect.y = window1Rect.y + 50;
				//guiButton3Rect.x = window1Rect.x;
				//guiButton3Rect.y = window1Rect.y + 100;

				guiButton4Rect.x = window2Rect.x;
				guiButton4Rect.y = window2Rect.y;

				guiButton5Rect.x = window3Rect.x;
				guiButton5Rect.y = window3Rect.y;
			}
		}



		// Move with GUI and buttons together
		if(isMoveable2 == false){
			if(GUI.Button(buttons2Rect2, "Moveable stick")){
				isMoveable = true;
				isMoveable2 = true;
			}
		}
		else {
			window1Rect = GUILayout.Window(1, window1Rect, window1Function, "Stick 1");
			window2Rect = GUILayout.Window(2, window2Rect, window2Function, "Stick 2");
			window3Rect = GUILayout.Window(3, window3Rect, window3Function, "Stick 3");
			guiButton1GroupRect.x = window1Rect.x;
			guiButton1GroupRect.y = window1Rect.y;
			//guiButton2Rect.x = window1Rect.x;
			//guiButton2Rect.y = window1Rect.y + 50;
			//guiButton3Rect.x = window1Rect.x;
			//guiButton3Rect.y = window1Rect.y + 100;
			
			guiButton4Rect.x = window2Rect.x;
			guiButton4Rect.y = window2Rect.y;
			
			guiButton5Rect.x = window3Rect.x;
			guiButton5Rect.y = window3Rect.y;
			if(GUI.Button(buttons2Rect2, "Moveable unstick")){
				isMoveable2 = false;
			}
		}
	}

	
	// Window 1
	void window1Function(int id){
		if(GUILayout.Button("GUIB1")){
			print ("GUIButton1");
		}
		if(GUILayout.Button("GUIB2")){
			print ("GUIButton2");
		}
		if(GUILayout.Button("GUIB3")){
			print ("GUIButton3");
		}
		
		if(isMoveable == true){
			GUI.DragWindow (new Rect (0, 0, 10000, 10000));
		}
	}

	// Window 2
	void window2Function(int id){
		if(GUILayout.Button("GUIB4")){
			print ("GUIButton4");
		}

		if(isMoveable == true){
			GUI.DragWindow (new Rect (0, 0, 10000, 10000));
		}
	}

	// Window 3
	void window3Function(int id){
		if(GUILayout.Button("GUIB5")){
			print ("GUIButton5");
		}

		if(isMoveable == true){
			GUI.DragWindow (new Rect (0, 0, 10000, 10000));
		}
	}

	void resetGUI(){
		window1Rect = new Rect(0, 0, 50, 150);
		window2Rect = new Rect(200, 0, 50, 50);
		window3Rect = new Rect(0, 200, 50, 50);
		buttons1Rect = new Rect(Screen.width-70, 0, 70, 50);
		buttons2Rect = new Rect(Screen.width-120, 50, 120, 50);
		buttons2Rect2 = new Rect(Screen.width-120, 100, 120, 50);
		guiButton1GroupRect = new Rect(0, 0, 210, 150);
		guiButton1Rect = new Rect(0, 0, 70, 50);
		guiButton2Rect = new Rect(0, 50, 70, 50);
		guiButton3Rect = new Rect(0, 100, 70, 50);
		guiButton4Rect = new Rect(200, 0, 70, 50);
		guiButton5Rect = new Rect(0, 200, 70, 50);
	}

	void guiButtons1(){
		if(GUI.Button(guiButton1Rect, "GUIB1")){
			print ("GUIButton1");
		}
		if(GUI.Button(guiButton2Rect, "GUIB2")){
			print ("GUIButton2");
		}
		if(GUI.Button(guiButton3Rect, "GUIB3")){
			print ("GUIButton3");
		}
		/*
		if(GUILayout.Button("GUIB1")){
			print ("GUIButton1");
		}
		if(GUILayout.Button("GUIB2")){
			print ("GUIButton2");
		}
		if(GUILayout.Button("GUIB3")){
			print ("GUIButton3");
		}
		*/
	}
}
