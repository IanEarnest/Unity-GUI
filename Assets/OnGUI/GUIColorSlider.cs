using UnityEngine;
using System.Collections;

public class GUIColorSlider : MonoBehaviour {
	
	Color myColor;
	Color red;
	Color green;
	Color blue;
	public GUIStyle redStyle;
	public GUIStyle greenStyle;
	public GUIStyle blueStyle;
	public GameObject ball;
	
	void OnGUI () {	
		if(OnGUIMenu.menuSelect == 3){
			// Set colour of ball to rgb.
			ball.renderer.material.SetColor("_Color", myColor);
			
			// Make colour visible. 
			red.a = 1;
			green.a = 1;
			blue.a = 1;
			
			// Set each value of each colour.
			red.r = myColor.r;
			green.g = myColor.g;
			blue.b = myColor.b;
			
			// Set each style text colour to each colour.
			redStyle.normal.textColor = red;
			greenStyle.normal.textColor = green;
			blueStyle.normal.textColor = blue;
			
			// Red
			Rect myColorRect = new Rect (10,10,200,30);
			GUI.Label (myColorRect, "Red", redStyle);
			myColorRect.x += myColorRect.width; 
			myColor.r = GUI.HorizontalSlider (myColorRect, myColor.r, 0.0f, 1.0f);
			
			// Green
			myColorRect = new Rect (10,10,200,30);
			myColorRect.y += 30;
			GUI.Label (myColorRect, "Green", greenStyle);
			myColorRect.x += myColorRect.width; 
			myColor.g = GUI.HorizontalSlider (myColorRect, myColor.g, 0.0f, 1.0f);
			
			// Blue
			myColorRect = new Rect (10,10,200,30);
			myColorRect.y += 60;
			GUI.Label (myColorRect, "Blue", blueStyle);
			myColorRect.x += myColorRect.width; 
			myColor.b = GUI.HorizontalSlider (myColorRect, myColor.b, 0.0f, 1.0f);
		}
	}
}