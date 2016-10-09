using UnityEngine;
using System.Collections;

public class click4 : MonoBehaviour {
    public Main2 main;
    public void OnMouseDown()
    {
        Debug.Log("clcked3");
        main.testCorrect(3);

    }
}
