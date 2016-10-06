using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour {

	//when start button is pressed.
	public void OnGameStart(string s){
		Debug.Log ("you pressed start");

		//Add load level for new scene here.

		SceneManager.LoadScene (s);
	}
}
