using UnityEngine;
using System.Collections;

public class click3 : MonoBehaviour
{
    public Main main;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit,100))
            {
            

                Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object              
                Debug.Log("clcked2");
                main.testCorrect(2); 

                /*         void OnSelect()
             {


                 // If the sphere has no Rigidbody component, add one to enable physics.
                 if (!this.GetComponent<Rigidbody>())
                 {
                    // var rigidbody = this.gameObject.AddComponent<Rigidbody>();
                   //  rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
                 }
                 OnMouseDown();*/
            }
        }
    }/*
    void OnSelect()
    {


        // If the sphere has no Rigidbody component, add one to enable physics.
        if (!this.GetComponent<Rigidbody>())
        {
            var rigidbody = this.gameObject.AddComponent<Rigidbody>();
            rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        }
        blueclick();
        // OnMouseDown();
    }*/
}
