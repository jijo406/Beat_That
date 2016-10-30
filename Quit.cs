using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

  
    public void buttonPressed()
       
    {   
        Debug.Log("Quit");
        Application.Quit();

    }
}
