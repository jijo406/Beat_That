using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour {

	public void buttonPressed(string s)
    {
        Debug.Log("button was pressed");
        SceneManager.LoadScene(s);

    }
}
