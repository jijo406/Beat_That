using UnityEngine;
using System.Collections;

public class QuitGameScript : MonoBehaviour {

	//quits game when button is clicked
	public void quitGame(){
		Debug.Log ("quit pressed");
		Application.Quit ();
	}
}
