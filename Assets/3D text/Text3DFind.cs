using UnityEngine;
using System.Collections;

public class Text3DFind : MonoBehaviour {

	// Attach script to Main Camera or
	// empty game object to activate.

	// 3D TextMeshes
	TextMesh TextMesh1;
	TextMesh TextMesh2;
	
	
	/// <summary>
	/// Finds TextMeshes.
	/// </summary>
	/// <returns>
	/// TextMesh.
	/// </returns>
	/// <param name='textMesh'>
	/// The TextMesh variable you wish to link to the TextMesh.
	/// </param>
	/// <param name='name'>
	/// Name of the gameObject in scene.
	/// </param>
	TextMesh findMesh(TextMesh textMesh, string name){
		textMesh = GameObject.Find(name).GetComponent("TextMesh") as TextMesh;
		return textMesh;
	}
	
	void Start () {
		// Find all the text meshes
		TextMesh1 = findMesh(TextMesh1,"Text Mesh 1");
		TextMesh2 = findMesh(TextMesh2,"Text Mesh 2");
	}

	void Update(){
		TextMesh1.text = "Changed";
		TextMesh2.text = "Changed";
	}
}
