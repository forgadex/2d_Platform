using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class Buttons_Action : MonoBehaviour{


	public void OnQuitButtonClick(){

		Application.Quit ();

	}
	public void OnButtonClick(){

		SceneManager.LoadScene(gameObject.tag, LoadSceneMode.Additive);

	}

}
