using UnityEngine;
using System.Collections;

public class Text3DChange : MonoBehaviour {

	
	public TextMesh change1Btn;
	public TextMesh change2Btn;
	Text3DFind ScriptFindText;
	TextMesh textToChange1;
	TextMesh textToChange2;

	public TextMesh clearBtn;
	Text3DClear ScriptClearText;
	public TextMesh textToClear1;
	public TextMesh textToClear2;

	Ray ray;
	RaycastHit hit;

	// Use this for initialization
	void Start () {
		ScriptClearText = clearBtn.gameObject.AddComponent <Text3DClear>();
		ScriptFindText = clearBtn.gameObject.AddComponent <Text3DFind>();
		textToChange1 = ScriptFindText.findMesh(textToChange1, "Text Change 1");
		textToChange2 = ScriptFindText.findMesh(textToChange2, "Text Change 2");

	}

	// Update is called once per frame
	void Update () {
		normalFontStyles ();

		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out hit)){
			changeTexts();
			clearTexts();
		}
	}

	void normalFontStyles () {
		change1Btn.fontStyle = FontStyle.Normal;
		change2Btn.fontStyle = FontStyle.Normal;
		clearBtn.fontStyle = FontStyle.Normal;
	}


	/// <summary>
	/// Mouse hover makes text bold.
	/// Mouse click returns true.
	/// </summary>
	/// <returns><c>true</c>, if text was hit, <c>false</c> otherwise.</returns>
	/// <param name="text">Text.</param>
	bool hitText (TextMesh text) {
		bool click = false;
		
		if(hit.transform.name == text.name){
			text.fontStyle = FontStyle.Bold;
			if(Input.GetMouseButtonDown(0)){
				click = true;
			}
		}
		return click;
	}


	void changeTexts(){
		if(hitText(change1Btn)){
			textToChange1.text = "Changed 1";
		}
		
		if(hitText(change2Btn)){
			textToChange2.text = "Changed 2";
		}
	}

	void clearTexts(){
		if(hitText(clearBtn)){
			if(textToClear1){
				ScriptClearText.clearText (textToClear1);
			}
			else{
				ScriptClearText.clearText (textToClear2);
			}
		}
	}
}
