using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {

	int activeCamera = 1;
	public Camera firstPersonCamera;
	public Camera thirdPersonCamera;
	public Transform sphere;
	Vector3 firstPersonGUIOrigin;
	Vector3 thirdPersonGUIOrigin;


	void Start(){
		// Keep GUI in original position
		firstPersonGUIOrigin = firstPersonCamera.GetComponentInChildren<GUIText>().transform.position;
		thirdPersonGUIOrigin = thirdPersonCamera.GetComponentInChildren<GUIText>().transform.position;
	}

	void OnGUI () {
		// Instructions
		GUI.Label (new Rect(Screen.width/2-100, 0, 200, 20),"Press space to change camera");
	}

	// Update is called once per frame
	void Update () {
		// Switch between cameras using space bar
		if(Input.GetKeyDown(KeyCode.Space)){
			activeCamera++;
			if(activeCamera > 3){ 
				activeCamera = 1; 
			}
			print ("switch to camera: " + activeCamera);
		}
        
        if (activeCamera == 1) {
			camera.enabled = true;
			gameObject.GetComponentInChildren<GUIText>().enabled = true;
			firstPersonCamera.enabled = false;
			firstPersonCamera.GetComponentInChildren<GUIText>().enabled = false;
			thirdPersonCamera.enabled = false;
			thirdPersonCamera.GetComponentInChildren<GUIText>().enabled = false;
		}

		if (activeCamera == 2) {
			camera.enabled = false;
			gameObject.GetComponentInChildren<GUIText>().enabled = false;
			firstPersonCamera.enabled = true;
			firstPersonCamera.GetComponentInChildren<GUIText>().enabled = true;
			thirdPersonCamera.enabled = false;
			thirdPersonCamera.GetComponentInChildren<GUIText>().enabled = false;
		}

		if (activeCamera == 3) {
			camera.enabled = false;
			gameObject.GetComponentInChildren<GUIText>().enabled = false;
			firstPersonCamera.enabled = false;
			firstPersonCamera.GetComponentInChildren<GUIText>().enabled = false;
			thirdPersonCamera.enabled = true;
			thirdPersonCamera.GetComponentInChildren<GUIText>().enabled = true;;
		}

		// Camera follow sphere
		firstPersonCamera.transform.position = sphere.position;

		// Camera follow sphere only x and y
		Vector3 tempPos = thirdPersonCamera.transform.position;
		tempPos.x = sphere.position.x;
		tempPos.y = sphere.position.y;
		thirdPersonCamera.transform.position = tempPos;

		// Keep GUI in original position
		firstPersonCamera.GetComponentInChildren<GUIText>().transform.position = firstPersonGUIOrigin;
		thirdPersonCamera.GetComponentInChildren<GUIText>().transform.position = thirdPersonGUIOrigin;
	}
}
