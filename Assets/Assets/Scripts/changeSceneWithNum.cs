using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneWithNum : MonoBehaviour {

	public string numPerson;
	public string scene1 = "Assets/Scenes/1";
	public string scene2 = "Assets/Scenes/2";
	public string scene3 = "Assets/Scenes/3";
	public string scene4 = "Assets/Scenes/4";


	public RadialMenu radialMenu;




	// Use this for initialization
	void Start () {

	//	GameObject mainMenuObject = GameObject.FindWithTag ("radialMenuButton");
//		radialMenu = mainMenuObject.GetComponent<RadialMenu> ();
		//GameObject mainMenu = GameObject.FindGameObjectsWithTag("MainMenu");
		//RadialMenu script = mainMenu.GetComponent<RadialMenu>();



	}
	
	// Update is called once per frame
	void Update () {

//		numPerson = radialMenu.whatNumIsSelected;
		//print ("--------"+numPerson);
		//print ("++++++++"+radialMenu.whatNumIsSelected);
	}

	public void Try_it_change_Scene_AA(string x){
		if(x.Equals("1"))
			SceneManager.LoadScene(scene1);
		if(x.Equals("2"))
			SceneManager.LoadScene(scene2);
		if(x.Equals("3"))
			SceneManager.LoadScene(scene3);
		if(x.Equals("4"))
			SceneManager.LoadScene(scene4);
	}
}
