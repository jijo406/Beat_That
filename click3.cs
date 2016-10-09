using UnityEngine;
using System.Collections;

public class click3 : MonoBehaviour
{
    public Main2 main;
    public void OnMouseDown()
    {
        Debug.Log("clcked2");
        main.testCorrect(2);

    }
}
