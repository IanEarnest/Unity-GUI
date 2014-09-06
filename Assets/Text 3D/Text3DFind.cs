using UnityEngine;
using System.Collections;

public class Text3DFind : MonoBehaviour {


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
	public TextMesh findMesh(TextMesh textMesh, string name){
		textMesh = GameObject.Find(name).GetComponent("TextMesh") as TextMesh;
		return textMesh;
	}
}
