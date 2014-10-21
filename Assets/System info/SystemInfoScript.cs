using UnityEngine;
using System; // system is only used on standalone.
using System.Collections;

public class SystemInfoScript : MonoBehaviour {
	
	string internetAccess = "";

	Rect infoRect = new Rect(95.8f, -2.8f, 420, 10000);

	bool showGeneral;
	bool showUser;
	bool showUnity;
	bool showSpecs;
	bool showEnvironment;


	void Update(){

		// Display message for internet access
		//NetworkReachability.NotReachable 						// No LAN or Mobile
		//NetworkReachability.ReachableViaCarrierDataNetwork 	// Mobile network
		//NetworkReachability.ReachableViaLocalAreaNetwork 		// LAN network
		if(Application.internetReachability == NetworkReachability.NotReachable){
			internetAccess = "No internet";
		}
		else if(Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork){
			internetAccess = "Mobile network active";
        }
		else if(Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork){
			internetAccess = "LAN active";
        }
	}


	void OnGUI(){
		if(GUILayout.Button("General")){
			showGeneral = !showGeneral;
		}
		if(GUILayout.Button("Specs")){
			showSpecs = !showSpecs;
		}
		if(Application.isWebPlayer == false){
			if(GUILayout.Button("Environment")){
				showEnvironment = !showEnvironment;
			}
		}

#if !UNITY_WEBPLAYER
		// Also disable if unity android
		if(GUILayout.Button("Unity")){
			showUnity = !showUnity;
		}

		if(GUILayout.Button("User")){
			showUser = !showUser;
		}
#endif



		GUILayout.BeginArea (infoRect);
		if(showGeneral == true){
			GUILayout.Label("General" + 
			                "\nLanguage: " + Application.systemLanguage +
			                "\nNetwork: " + internetAccess);
		}

		if(showSpecs == true){
			GUILayout.Label("Computer specs" +
							"\nComputer name: " + SystemInfo.deviceName +
			                "\nComputer type: " + SystemInfo.deviceType + 
			                "\nOS: " + SystemInfo.operatingSystem + 
			                "\nProcessor: " + SystemInfo.deviceModel + 
			                "\nGraphics: " + SystemInfo.graphicsDeviceName + 
			                "\nMemory: " + SystemInfo.systemMemorySize);
		}
			if(showEnvironment == true){
				GUILayout.Label("Environment" + 

				                "\nMachineName: " + Environment.MachineName + 
				                "\nUserDomainName: " + Environment.UserDomainName + 
	                            "\nUserName: " + Environment.UserName + 
				               
				                "\nHasShutdownStarted: " + Environment.HasShutdownStarted + 

				                "\nOSVersion: " + Environment.OSVersion + 
				                "\nVersion: " + Environment.Version + 
				                "\nProcessorCount: " + Environment.ProcessorCount + 
				                //"\nStackTrace: " + Environment.StackTrace + 

				                "\nTickCount: " + Environment.TickCount + 
				                "\nUserInteractive: " + Environment.UserInteractive);
			}

			if(showUnity == true){
				GUILayout.Label("Unity " + 
				                "\nCommandLine: " + Environment.CommandLine + 
				                "\nCurrentDirectory: " + Environment.CurrentDirectory);
			}
			if(showUser == true){
				GUILayout.Label("User " +
				                "\nUserName: " + Environment.UserName + 
				                "\nMachineName: " + Environment.MachineName
				                );
			}
		GUILayout.EndArea ();
    }
}
