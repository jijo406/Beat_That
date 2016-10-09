using UnityEngine;
using System.Collections;

public class ClickAction : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rhInfo;
            bool didHit = Physics.Raycast(ray, out rhInfo, 500.0f);
            if (didHit)
            {
                Debug.Log(rhInfo.collider.name + "   " + rhInfo.point);
                BlueScript blueScript = rhInfo.collider.GetComponent<BlueScript>();
                if(blueScript)
                {
                    blueScript.pickACube(rhInfo.collider.name);
                }
            }
            else
            {
                Debug.Log("clicked on empty space");
            }
        }
    }
}