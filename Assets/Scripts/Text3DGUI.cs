using UnityEngine;
using System.Collections;

public class Text3DGUI : MonoBehaviour {

	// Uses render.enabled to see if that menu 
	// is enabled then changes children depending.


	public TextMesh Menu1;
	public TextMesh Option1;
	public TextMesh Option2;
	public TextMesh Othermenu;
	public TextMesh Menu2;
	public TextMesh Anotheroption1;
	public TextMesh Anotheroption2;
	public TextMesh Firstmenu;

	// Use this for initialization
	void Start () {
		Menu1.renderer.enabled = true;
		Menu2.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		Ray ray;
		RaycastHit hit;
		
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out hit)){

			print (hit.transform.name);
			// Reset all fontStyles
			Menu1.fontStyle = FontStyle.Normal;
			Option1.fontStyle = FontStyle.Normal;
			Option2.fontStyle = FontStyle.Normal;
			Othermenu.fontStyle = FontStyle.Normal;
			Menu2.fontStyle = FontStyle.Normal;
			Anotheroption1.fontStyle = FontStyle.Normal;
			Anotheroption2.fontStyle = FontStyle.Normal;
			Firstmenu.fontStyle = FontStyle.Normal;

			if(hit.transform.name == "Menu 1"){
				Menu1.fontStyle = FontStyle.Italic;
				if(Input.GetMouseButtonDown(0)){
					print("Menu 1 pressed");
				}
			}
			if(hit.transform.name == "Option 1"){
				Option1.fontStyle = FontStyle.Bold;
				if(Input.GetMouseButtonDown(0)){
					print("Option 1 pressed");
				}
			}
			if(hit.transform.name == "Option 2"){
				Option2.fontStyle = FontStyle.Bold;
				if(Input.GetMouseButtonDown(0)){
					print("Option 2 pressed");
				}
			}
			if(hit.transform.name == "Menu 2"){
				Menu2.fontStyle = FontStyle.Italic;
				if(Input.GetMouseButtonDown(0)){
					print("Menu 2 pressed");
				}
			}
			if(hit.transform.name == "Other Menu"){
				Othermenu.fontStyle = FontStyle.Bold;
				if(Input.GetMouseButtonDown(0)){
					Menu1.renderer.enabled = false;
					Menu2.renderer.enabled = true;
				}
			}
			if(hit.transform.name == "Another Option 1"){
				Anotheroption1.fontStyle = FontStyle.Bold;
				if(Input.GetMouseButtonDown(0)){
					print("Another Option 1 pressed");
				}
			}
			if(hit.transform.name == "Another Option 2"){
				Anotheroption2.fontStyle = FontStyle.Bold;
				if(Input.GetMouseButtonDown(0)){
					print("Another Option 2 pressed");
				}
			}
			if(hit.transform.name == "First Menu"){
				Firstmenu.fontStyle = FontStyle.Bold;
				if(Input.GetMouseButtonDown(0)){
					Menu1.renderer.enabled = true;
					Menu2.renderer.enabled = false;
				}
			}
		}
		
		
		if (Physics.Raycast(ray)){
		}

		// Hide menu children.
		if(Menu1.renderer.enabled == false){
			Menu1.collider.enabled = false;
			foreach (Transform child in Menu1.transform){
				child.renderer.enabled = false;
				child.collider.enabled = false;
			}
		}
		else{
			Menu1.collider.enabled = true;
			foreach (Transform child in Menu1.transform){
				child.renderer.enabled = true;
				child.collider.enabled = true;
			}
		}
		if(Menu2.renderer.enabled == false){
			Menu2.collider.enabled = false;
			foreach (Transform child in Menu2.transform){
				child.renderer.enabled = false;
				child.collider.enabled = false;
			}
		}
		else{
			Menu2.collider.enabled = true;
			foreach (Transform child in Menu2.transform){
				child.renderer.enabled = true;
				child.collider.enabled = true;
			}
		}
	}
}
