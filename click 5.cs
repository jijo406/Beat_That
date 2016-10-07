using UnityEngine;
using System.Collections;

public class click5 : MonoBehaviour {

    public Main2 main;
    public void OnMouseDown()
    {
        Debug.Log("clcked4");
        main.testCorrect(4);
    }

    void OnSelect()
    {

        ;
        // If the sphere has no Rigidbody component, add one to enable physics.
        if (!this.GetComponent<Rigidbody>())
        {
            //  var rigidbody = this.gameObject.AddComponent<Rigidbody>();
            // rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        }
        OnMouseDown();
    }
}
