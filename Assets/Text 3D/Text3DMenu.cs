using UnityEngine;
using System.Collections;

public class Text3DMenu : MonoBehaviour {


	public GameObject Menu1; // Menu 1
	public GameObject Menu2; // Menu 2

	public TextMesh Menu1Title; // Menu 1 Title
	public TextMesh Menu2Title; // Menu 2 Title

	public TextMesh Menu1Btn; // Menu 1 Btn
	public TextMesh Menu2Btn; // Menu 2 Btn

	public TextMesh Option1Btn; // Option 1 Btn
	public TextMesh Option2Btn; // Option 2 Btn
	public TextMesh Option3Btn; // Option 3 Btn
	public TextMesh Option4Btn; // Option 4 Btn

	bool Menu1Active = true;
	bool Menu2Active;

	string hitObject = "none";

	Ray ray;
	RaycastHit hit;


	// Use this for initialization
	void Start () {
		// Show first menu only
		Menu1Title.renderer.enabled = true;
		Menu2Title.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		resetFontStyles();

		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out hit)){

			mouseTracking();

			clickingButtons();
		}
		hideMenuChildren();
	}


	// Reset all fontStyles
	void resetFontStyles(){
		Menu1Title.fontStyle = FontStyle.Normal;
		Option1Btn.fontStyle = FontStyle.Normal;
		Option2Btn.fontStyle = FontStyle.Normal;
		Menu2Btn.fontStyle = FontStyle.Normal;
		Menu2Title.fontStyle = FontStyle.Normal;
		Option3Btn.fontStyle = FontStyle.Normal;
		Option4Btn.fontStyle = FontStyle.Normal;
		Menu1Btn.fontStyle = FontStyle.Normal;
	}


	// Print when hovering new objects and
	// Print when clicking objects
	void mouseTracking(){

		if(hitObject != hit.transform.name && 
		   hit.transform.name != "Background"){
			print (hit.transform.name + " hover");
		}
		hitObject = hit.transform.name;
		

		if(Input.GetMouseButtonDown(0) && 
		   hit.transform.name != "Background"){
			print(hitObject + " pressed");
		}
	}


	// Hide menu children.
	// Uses render.enabled to see if that menu 
	// is enabled then changes children depending.
	void hideMenuChildren(){
		if(Menu1Active == true){
			foreach (Transform child in Menu2.transform){
				child.renderer.enabled = false;
				child.collider.enabled = false;
			}
		}
		else {
			foreach (Transform child in Menu2.transform){
				child.renderer.enabled = true;
				child.collider.enabled = true;
			}
		}

		if(Menu2Active == true){
			foreach (Transform child in Menu1.transform){
				child.renderer.enabled = false;
				child.collider.enabled = false;
			}
		}
		else {
			foreach (Transform child in Menu1.transform){
				child.renderer.enabled = true;
				child.collider.enabled = true;
			}
		}

		/*
		if(Menu1Title.renderer.enabled == false){
			Menu1Title.collider.enabled = false;
			foreach (Transform child in Menu1Title.transform){
				child.renderer.enabled = false;
				child.collider.enabled = false;
			}
		}
		else{
			Menu1Title.collider.enabled = true;
			foreach (Transform child in Menu1Title.transform){
				child.renderer.enabled = true;
				child.collider.enabled = true;
			}
		}
		if(Menu2Title.renderer.enabled == false){
			Menu2Title.collider.enabled = false;
			foreach (Transform child in Menu2Title.transform){
				child.renderer.enabled = false;
				child.collider.enabled = false;
			}
		}
		else{
			Menu2Title.collider.enabled = true;
			foreach (Transform child in Menu2Title.transform){
				child.renderer.enabled = true;
				child.collider.enabled = true;
			}
		}
		*/
	}

	// Clicking buttons
	void clickingButtons(){
		if(hit.transform.name == Menu1Title.name){
			Menu1Title.fontStyle = FontStyle.Italic;
		}
		if(hit.transform.name == Option1Btn.name){
			Option1Btn.fontStyle = FontStyle.Bold;
		}
		if(hit.transform.name == Option2Btn.name){
			Option2Btn.fontStyle = FontStyle.Bold;
		}
		if(hit.transform.name == Menu2Title.name){
			Menu2Title.fontStyle = FontStyle.Italic;
		}
		if(hit.transform.name == Menu2Btn.name){
			Menu2Btn.fontStyle = FontStyle.Bold;
			if(Input.GetMouseButtonDown(0)){
				//Menu1Title.renderer.enabled = false;
				//Menu2Title.renderer.enabled = true;
				Menu1Active = false;
				Menu2Active = true;
			}
		}
		if(hit.transform.name == Option3Btn.name){
			Option3Btn.fontStyle = FontStyle.Bold;
		}
		if(hit.transform.name == Option4Btn.name){
			Option4Btn.fontStyle = FontStyle.Bold;
		}
		if(hit.transform.name == Menu1Btn.name){
			Menu1Btn.fontStyle = FontStyle.Bold;
			if(Input.GetMouseButtonDown(0)){
				//Menu1Title.renderer.enabled = true;
				//Menu2Title.renderer.enabled = false;
				Menu1Active = true;
				Menu2Active = false;
			}
		}
	}
}
