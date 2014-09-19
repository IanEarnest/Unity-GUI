using UnityEngine;
using System.Collections;

public class Text3DClear : MonoBehaviour {
	
	float myTime;
	bool isClearText;
	TextMesh myText;

	void Update(){
		myTime += 0.024f;

		if (isClearText == true) {
			if(myText != null){
				myText.renderer.material.color = Color.Lerp(Color.white, Color.clear, myTime/5);
				if(myText.renderer.material.color == Color.clear) {
					DestroyImmediate(myText.gameObject);
				}
			}
		}
	}


	/// <summary>
	/// Clears the text.
	/// </summary>
	/// <param name="Text">Text.</param>
	public void clearText(TextMesh Text){
		resetTime();
		isClearText = true;
		myText = Text;
	}

	public void resetTime(){
		myTime = 0;
	}
}
