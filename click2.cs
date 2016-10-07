using UnityEngine;
using System.Collections;

public class click2 : MonoBehaviour
{
    public Main2 main;
    public void OnMouseDown()
    {
        Debug.Log("clcked0");
        main.testCorrect(0);

    }
}


