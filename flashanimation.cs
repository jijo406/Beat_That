using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class flashanimation {

    
    void Start () {
      

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public IEnumerator playBack(List<int> pattern, GameObject Red, GameObject Blue)
    {
        Debug.Log("in playback");
        
       
            if (pattern != null)
            {
                Debug.Log("pattern count: " + pattern.Count);
                for (int p = 0; p < pattern.Count; p++)
                {
                    if (pattern[p] == 0)
                    {
                        Debug.Log("made it to red");
                        //   Red.transform.Rotate(Vector3.up, Time.deltaTime * 30, Space.World);
                        Red.GetComponent<Renderer>().material.color = Color.white;
                        yield return new WaitForSeconds(0.6f);
                        Red.transform.GetComponent<Renderer>().material.color = Color.red;
                        yield return new WaitForSeconds(0.3f);

                    }

                    else if (pattern[p] == 2)
                    {
                        Debug.Log("made it to blue");
                        Blue.GetComponent<Renderer>().material.color = Color.white;
                        yield return new WaitForSeconds(0.6f);
                        Blue.GetComponent<Renderer>().material.color = Color.blue;
                        yield return new WaitForSeconds(0.3f);

                    }
                }
            }
        yield return new WaitForSeconds(0.7f);


    }
}
