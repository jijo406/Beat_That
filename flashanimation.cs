using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class flashanimation {

   
    public IEnumerator playBack(List<int> pattern, GameObject Red, GameObject Blue, GameObject Green, GameObject Yellow)
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
                 //   int count = 0;

                    //Red.GetComponent<Renderer>().material.color = Color.red;
                    // Red.transform.Rotate(Vector3.up, Time.deltaTime * 30, Space.World);  
                    /*
                    while (count <500000)
                    {
                        Red.transform.Rotate(Vector3.up * Time.deltaTime);
                        count++;
                        */
                        yield return new WaitForSeconds(0.6f);
                        Red.GetComponent<Renderer>().material.color = Color.white;
                        Red.transform.Rotate(new Vector3(0, 180, 0), Time.deltaTime *500000, Space.World);
                        yield return new WaitForSeconds(0.6f);
                        Red.transform.Rotate(new Vector3(0,180, 0), Time.deltaTime * 500000, Space.World);
                        yield return new WaitForSeconds(0.6f);
                        Red.transform.GetComponent<Renderer>().material.color = Color.red;
                        yield return new WaitForSeconds(0.3f);

                    }

                else if (pattern[p] == 1)
                {

                    Debug.Log("made it to green");




                    yield return new WaitForSeconds(0.6f);
                    Green.GetComponent<Renderer>().material.color = Color.white;
                    Green.transform.Rotate(new Vector3(0, 180, 0), Time.deltaTime * 500000, Space.World);
                    yield return new WaitForSeconds(0.6f);
                    Green.transform.Rotate(new Vector3(0, 180, 0), Time.deltaTime * 500000, Space.World);
                    yield return new WaitForSeconds(0.6f);
                    Green.GetComponent<Renderer>().material.color = Color.green;
                    yield return new WaitForSeconds(0.3f);

                }

                else if (pattern[p] == 2)
                    {
                 
                        Debug.Log("made it to blue");
                    
                       
                       

                        yield return new WaitForSeconds(0.6f);
                        Blue.GetComponent<Renderer>().material.color = Color.white;
                    Blue.transform.Rotate(new Vector3(0,180,0), Time.deltaTime * 500000, Space.World);
                    yield return new WaitForSeconds(0.6f);
                    Blue.transform.Rotate(new Vector3(0,180, 0), Time.deltaTime * 500000, Space.World);
                    yield return new WaitForSeconds(0.6f);     
                    Blue.GetComponent<Renderer>().material.color = Color.blue;
                    yield return new WaitForSeconds(0.3f);
                       
                }
                else if (pattern[p] == 3)
                {

                    Debug.Log("made it to yellow");




                    yield return new WaitForSeconds(0.6f);
                    Yellow.GetComponent<Renderer>().material.color = Color.white;
                    Yellow.transform.Rotate(new Vector3(0, 180, 0), Time.deltaTime * 500000, Space.World);
                    yield return new WaitForSeconds(0.6f);
                    Yellow.transform.Rotate(new Vector3(0, 180, 0), Time.deltaTime * 500000, Space.World);
                    yield return new WaitForSeconds(0.6f);
                    Yellow.GetComponent<Renderer>().material.color = Color.yellow;
                    yield return new WaitForSeconds(0.3f);

                }


            }
            }
        yield return new WaitForSeconds(0.7f);



    }

   
}
