using UnityEngine;
using System.Collections;

public class Text3DClear : MonoBehaviour {
	

	/// <summary>
	/// Clears the text.
	/// </summary>
	/// <param name="Text">Text.</param>
	public void clearText(TextMesh Text){
		if(Text != null){
			Text.renderer.material.color = Color.Lerp(Color.white, Color.clear, Time.time/5);
			if(Text.renderer.material.color == Color.clear) {
				DestroyImmediate(Text.gameObject);
			}
		}
	}
}
