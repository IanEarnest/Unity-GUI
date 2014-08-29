using UnityEngine;
using System.Collections;

public class TextClear : MonoBehaviour {
	
	// Attatch this script to a gameObject 
	//and watch it disappear.
	
	void Update () {
		// Turn text transparent then delete object.
		renderer.material.color = Color.Lerp(Color.white, Color.clear, Time.time/2);
		if(renderer.material.color == Color.clear) {
			DestroyImmediate(gameObject);
		}
	}
}
