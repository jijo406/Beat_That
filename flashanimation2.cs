using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class flashanimation2 {

    public IEnumerator playBack(List<int> pattern, GameObject Red, GameObject Blue, GameObject Green, GameObject Yellow)
    {

        if (pattern != null)
        {
            for (int p = 0; p < pattern.Count; p++)
            {
                if (pattern[p] == 0)
                {
                    yield return new WaitForSeconds(0.6f);
                    Red.GetComponent<Renderer>().material.color = Color.white;
                    Red.transform.Rotate(new Vector3(0, 180, 0), Time.deltaTime * 500000, Space.World);
                    yield return new WaitForSeconds(0.6f);
                    Red.transform.Rotate(new Vector3(0, 180, 0), Time.deltaTime * 500000, Space.World);
                    yield return new WaitForSeconds(0.6f);
                    Red.transform.GetComponent<Renderer>().material.color = Color.red;
                    yield return new WaitForSeconds(0.3f);
                }
                else if (pattern[p] == 1)
                {
                    yield return new WaitForSeconds(0.6f);
                    Green.GetComponent<Renderer>().material.color = Color.white;
                    Green.transform.Rotate(new Vector3(0, 180, 0), Time.deltaTime * 500000, Space.World);
                    yield return new WaitForSeconds(0.6f);
                    Green.transform.Rotate(new Vector3(0, 180, 0), Time.deltaTime * 500000, Space.World);
                    yield return new WaitForSeconds(0.6f);
                    Green.transform.GetComponent<Renderer>().material.color = Color.green;
                    yield return new WaitForSeconds(0.3f);
                }
                else if (pattern[p] == 2)
                {
                    yield return new WaitForSeconds(0.6f);
                    Blue.GetComponent<Renderer>().material.color = Color.white;
                    Blue.transform.Rotate(new Vector3(0, 180, 0), Time.deltaTime * 500000, Space.World);
                    yield return new WaitForSeconds(0.6f);
                    Blue.transform.Rotate(new Vector3(0, 180, 0), Time.deltaTime * 500000, Space.World);
                    yield return new WaitForSeconds(0.6f);
                    Blue.GetComponent<Renderer>().material.color = Color.blue;
                    yield return new WaitForSeconds(0.3f);

                }
                else if (pattern[p] == 3)
                {
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
