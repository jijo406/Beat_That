using UnityEngine;
using System.Collections;

public class click : MonoBehaviour {
    public Main2 main;
    public void OnMouseDown()
    {
        Debug.Log("clcked1");
        main.testCorrect(1);
    }

}
