using UnityEngine;
using System.Collections;

public class NewGUI2 : MonoBehaviour {
	
	public static int scoreToWin = 5;
	public static string difficulty = "Medium";
	public static string[] difficultyList = {"Easy", "Medium", "Hard"};
	private string credits = "Creator \nIan Harcourt-Smith";
	
	int selected;
	string[] strings;
	
	private int selectedMain, selectedOptions, selectedAbout;
	private string[] stringsMain = {"Play", "Options", "About"};
	private string[] stringsOptions = {"Difficulty", "Win Score", "Back"};
	private string[] stringsAbout = {"Back"};
	private string[] stringsControls;
	private bool mainMenu = true;
	private bool optionsMenu, aboutMenu;
	private bool waitNext;
	
	void OnGUI(){
		// Centered main menu group grid.
		if(mainMenu == true){
			GUI.BeginGroup (new Rect (0, 400, 400, 500));
			GUI.Box (new Rect (0,0,100,150), new GUIContent ("", "Menu."));
			GUI.Box (new Rect (0,0,100,30), new GUIContent ("Main Menu", "Title."));
			selectedMain = GUI.SelectionGrid (new Rect (0,25, 100, 120), selectedMain, stringsMain, 1);
			GUI.EndGroup();
		}
		// Options menu.
		if(optionsMenu == true){
			GUI.BeginGroup (new Rect (Screen.width / 2 - -60, Screen.height / 2 - 100, 400, 500));
			GUI.Box (new Rect (0,0,100,150), new GUIContent ("", "Menu."));
			GUI.Box (new Rect (0,0,100,30), "Options Menu");
			selectedOptions = GUI.SelectionGrid (new Rect (0,25, 100, 120), selectedOptions, stringsOptions, 1);
			GUI.TextField (new Rect (25,49,52,18), difficulty);
			GUI.TextField (new Rect (40,91,20,18), "" + scoreToWin);
			GUI.EndGroup();
		}
		
		// About menu.
		if(aboutMenu == true){
			GUI.BeginGroup (new Rect (Screen.width / 2 - -60, Screen.height / 2 - 100, 400, 500));
			GUI.Box (new Rect (0,0,100,150), new GUIContent ("", "Menu."));
			GUI.Box (new Rect (0,0,100,30), "About Menu");
			GUI.TextArea (new Rect (0,30,100,75), credits);
			selectedAbout = GUI.SelectionGrid (new Rect (0,105, 100, 40), 0, stringsAbout, 1);
			GUI.EndGroup();
		}
	}
	
	
	// Determins menu currently set up and allows navigation.
	void menus(int menu,bool plus){
		// Main menu.
		if(menu == 1){
			selected = selectedMain;
			strings = stringsMain;
		}
		// Options menu.
		if(menu == 2){
			selected = selectedOptions;
			strings = stringsOptions;
		}
		// About menu.
		if(menu == 3){
			selected = selectedAbout;
			strings = stringsAbout;
		}
		
		if(selected != strings.Length){
			if(plus == true){
				selected++;
			}
			if(plus == false){
				selected--;
			}
		}			
		if(selected > strings.Length-1){
			selected = 0;
		}
		if(selected < 0){
			selected = strings.Length-1;
		}
		
		// Main menu.
		if(menu == 1){
			selectedMain = selected;
			stringsMain = strings;
		}
		// Options menu.
		if(menu == 2){
			selectedOptions = selected;
			stringsOptions = strings;
		}
		// About menu.
		if(menu == 3){
			selectedAbout = selected;
			stringsAbout = strings;
		}		
	}
	
	void Update(){
		
		// Back button quit.
		if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }
		
		// W for up navigation on menu.
		if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
			if(mainMenu == true){
				menus(1, false);
			}
			if(optionsMenu == true){
				menus(2, false);
			}
			if(aboutMenu == true){
				menus(3, false);
			}
		}
		// S for down navigation on menu.
		if(Input.GetKeyDown(KeyCode.S)  || Input.GetKeyDown(KeyCode.DownArrow)){
			if(mainMenu == true){
				menus(1, true);
			}
			if(optionsMenu == true){
				menus(2, true);
			}
			if(aboutMenu == true){
				menus(3, true);
			}
		}
		// Space to choose selection.
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Return)/* && selectedMain > -1 */){
			if(mainMenu == true && waitNext == false){
				if(stringsMain[selectedMain] == "Play"){
					print("Play.");
					waitNext = true;
				}
				if(stringsMain[selectedMain] == "Options"){
					print("Options.");
					mainMenu = false;
					optionsMenu = true;
					waitNext = true;
				}
				if(stringsMain[selectedMain] == "About"){
					print("About.");
					mainMenu = false;
					aboutMenu = true;
					waitNext = true;
				}
			}
			if(optionsMenu == true && waitNext == false){				
				if(stringsOptions[selectedOptions] == "Difficulty"){
					print("Difficulty.");
					// Increase difficulty setting/ reset to first.
					string tempDifficulty = "";
					if(difficulty == difficultyList[0]){
						tempDifficulty = difficultyList[1];
					}
					if(difficulty == difficultyList[1]){
						tempDifficulty = difficultyList[2];	
					}
					if(difficulty == difficultyList[2]){
						tempDifficulty = difficultyList[0];	
					}
					
					difficulty = tempDifficulty;
					waitNext = true;
				}
				if(stringsOptions[selectedOptions] == "Win Score"){
					print("Score.");
					// Increase win score/ reset to first.
					scoreToWin++;
					if(scoreToWin > 11){
						scoreToWin = 1;
					}
					waitNext = true;
				}
				if(stringsOptions[selectedOptions] == "Back"){
					print("Options back.");
					mainMenu = true;
					optionsMenu = false;
					selectedOptions = 0;
					waitNext = true;
				}
			}
			
			if(aboutMenu == true && waitNext == false){
				if(stringsAbout[selectedAbout] == "Back"){
					print("About back.");
					mainMenu = true;
					aboutMenu = false;
					selectedAbout = 0;
					waitNext = true;
				}
			}
		}
		waitNext = false;
	}
}
