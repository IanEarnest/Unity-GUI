using UnityEngine;
using System; // system is only used on standalone.
using System.Collections;

public class SystemInfoScript : MonoBehaviour {

	ScriptOne scriptOne = new ScriptOne();

	// Use this for initialization
	void Start () {
		// scriptOne update does not run?
		scriptOne.Steve();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUILayout.Label("Network reachability: " + Application.internetReachability);
		GUILayout.Label("System language: " + Application.systemLanguage);
		GUILayout.Label("deviceName: ");


		GUILayout.Label("deviceModel: " + SystemInfo.deviceModel + 
		                "\ndeviceName: " + SystemInfo.deviceName + 
		                "\ndeviceType: " + SystemInfo.deviceType + 
		                "\ngraphicsDeviceName: " + SystemInfo.graphicsDeviceName + 
		                "\noperatingSystem: " + SystemInfo.operatingSystem + 
		                "\nsystemMemorySize: " + SystemInfo.systemMemorySize);
		
		if(Application.isEditor){
			GUILayout.Label("CommandLine: " + Environment.MachineName);
		}
	}
}
