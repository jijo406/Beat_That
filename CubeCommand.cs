using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class CubeCommand : MonoBehaviour
{
    void OnSelect()
    {
        Debug.Log(this.gameObject.name + " was selected");
        transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
        BlueScript blue = new BlueScript();

        blue.pickACube(this.gameObject.name);
    }
    
    void onRed()
    {
        BlueScript blue = new BlueScript();
        blue.pickACube("Red");
    }
    
    void onBlue()
    {
        BlueScript blue = new BlueScript();
        blue.pickACube("Blue");
    }
    
    void onGreen()
    {
        BlueScript blue = new BlueScript();
        blue.pickACube("Green");
    }
    
    void onYellow()
    {
        BlueScript blue = new BlueScript();
        blue.pickACube("Yellow");
    }
    
    void onRed0()
    {
        BlueScript blue = new BlueScript();
        blue.pickACube("Red0");
    }
    
    void onBlue0()
    {
        BlueScript blue = new BlueScript();
        blue.pickACube("Blue0");
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    
   /* void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(this.gameObject.name + " was selected");
            this.gameObject.transform.Rotate(new Vector3(0, 0, 180)*Time.deltaTime);
        }
    }*/
}
