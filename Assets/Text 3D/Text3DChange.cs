using UnityEngine;
using System.Collections;

public class Text3DChange : MonoBehaviour {


	Text3DFind ScriptFindText = new Text3DFind();
	TextMesh textToChange1;
	TextMesh textToChange2;
	
	Text3DClear ScriptClearText = new Text3DClear();
	public TextMesh textToClear;


	// Use this for initialization
	void Start () {
		textToChange1 = ScriptFindText.findMesh(textToChange1, "Text Change 1");
		textToChange2 = ScriptFindText.findMesh(textToChange2, "Text Change 2");

	}
	
	// Update is called once per frame
	void Update () {
		textToChange1.text = "Changed 1";
		textToChange2.text = "Changed 2";

		ScriptClearText.clearText (textToClear);
	}
}
