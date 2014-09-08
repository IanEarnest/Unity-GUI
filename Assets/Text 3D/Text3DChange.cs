﻿using UnityEngine;
using System.Collections;

public class Text3DChange : MonoBehaviour {

	
	public TextMesh change1Btn;
	public TextMesh change2Btn;
	Text3DFind ScriptFindText = new Text3DFind();
	TextMesh textToChange1;
	TextMesh textToChange2;
	bool changeText1Active;
	bool changeText2Active;

	public TextMesh clearBtn;
	Text3DClear ScriptClearText = new Text3DClear();
	public TextMesh textToClear1;
	public TextMesh textToClear2;
	bool clearTextActive;

	Ray ray;
	RaycastHit hit;

	// Use this for initialization
	void Start () {
		textToChange1 = ScriptFindText.findMesh(textToChange1, "Text Change 1");
		textToChange2 = ScriptFindText.findMesh(textToChange2, "Text Change 2");

	}
	
	// Update is called once per frame
	void Update () {
		change1Btn.fontStyle = FontStyle.Normal;
		change2Btn.fontStyle = FontStyle.Normal;
		clearBtn.fontStyle = FontStyle.Normal;

		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out hit)){
			if(hit.transform.name == change1Btn.name){
				change1Btn.fontStyle = FontStyle.Bold;
				if(Input.GetMouseButtonDown(0)){
					changeText1Active = true;
				}
			}
			if(hit.transform.name == change2Btn.name){
				change2Btn.fontStyle = FontStyle.Bold;
				if(Input.GetMouseButtonDown(0)){
					changeText2Active = true;
				}
			}
			if(hit.transform.name == clearBtn.name){
				clearBtn.fontStyle = FontStyle.Bold;
				if(Input.GetMouseButtonDown(0)){
					clearTextActive = true;
				}
			}
		}


		if(changeText1Active == true){
			textToChange1.text = "Changed 1";
		}
		if(changeText2Active == true){
			textToChange2.text = "Changed 2";
		}
		if(clearTextActive == true){
			ScriptClearText.clearText (textToClear1);
		}

		ScriptClearText.clearText (textToClear2);
	}
}
