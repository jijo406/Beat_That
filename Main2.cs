using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.SceneManagement;


public class Main2 : MonoBehaviour
{
    private static int counting = 1;
    private GameObject Red;
    private GameObject Yellow;
    private GameObject Green;
    private GameObject Blue;
    private GameObject Purple;
    private GameObject Orange;
    
    /*private Material RedMaterial;
    private Material BlueMaterial;
    private Material GreenMaterial;
    private Material YellowMaterial;*/
    static List<int> pattern = new List<int>();
    int next;
    bool play_Back = false;
    int onInList = 0;
    int r;
    private string NewBeatThatProto;


    void Start()
    {
        Red = GameObject.Find("/Cubes/Red");
        Yellow = GameObject.Find("/Cubes/Yellow");
        Green = GameObject.Find("/Cubes/Green");
        Blue = GameObject.Find("/Cubes/Blue");
        Purple = GameObject.Find("/Cubes/Purple");
        Orange = GameObject.Find("/Cubes/Orange");
        //for(count; count < counting; count++)
        //{
        if(counting >= 9)
        {
            r = Random.Range(0, 6);
            pattern.Add(r);
        }

        else if (counting > 4 && counting < 9)
        {
            r = Random.Range(0, 4);
            pattern.Add(r);
        }
        else if (counting <= 4)
        {
            r = Random.Range(0, 2)*2;
            pattern.Add(r);
        }
        //}
        
        //Debug.Log(pattern[0]);
        StartCoroutine(playBack());


        //RedMaterial = Resources.Load("Red Material", typeof(Material)) as Material;
        //BlueMaterial = Resources.Load("Blue Material", typeof(Material)) as Material;
        //GreenMaterial = Resources.Load("Green Material", typeof(Material)) as Material;
        //YellowMaterial = Resources.Load("Yellow Material", typeof(Material)) as Material;

    }
    public static Main2 Instance { get; private set; }

    // Update is called once per frame
    void Update()
    {
        //Red.GetComponent<Renderer>().material.color = Color.white;
        //Blue.GetComponent<Renderer>().material.color = Color.white;
        //Yellow.GetComponent<Renderer>().material.color = Color.white;
        //Green.GetComponent<Renderer>().material.color = Color.white;  
        //StopCoroutine(playBack());
        
    }



    IEnumerator playBack()
    {
        Debug.Log(pattern.Count + " start " +"jlkj");
        play_Back = true;
        if (pattern != null)
        {
            for (int x = 0; x < pattern.Count; x++)
            {

                if (pattern[x] == 0)
                {
                    //Red.transform.Rotate(Vector3.up, Time.deltaTime * 50, Space.World);
                    //pattern.Remove(x);
                    Red.GetComponent<Renderer>().material.color = Color.white;
                    yield return new WaitForSeconds(0.6f);
                    Red.transform.GetComponent<Renderer>().material.color = Color.red;
                    yield return new WaitForSeconds(0.5f);
                    continue;
                }
                else if (pattern[x] == 1)
                {
                    //Green.transform.Rotate(Vector3.up, Time.deltaTime * 50, Space.World);
                    //pattern.Remove(x);
                    Green.GetComponent<Renderer>().material.color = Color.white;
                    yield return new WaitForSeconds(0.6f);
                    Green.GetComponent<Renderer>().material.color = Color.green;
                    yield return new WaitForSeconds(0.5f);
                    continue;
                }
                else if (pattern[x] == 2)
                {
                    //Blue.transform.Rotate(Vector3.up, Time.deltaTime * 50, Space.World);
                    //pattern.Remove(x);
                    Blue.GetComponent<Renderer>().material.color = Color.white;
                    yield return new WaitForSeconds(0.6f);
                    Blue.GetComponent<Renderer>().material.color = Color.blue;
                    yield return new WaitForSeconds(0.5f);
                    continue;
                }
                else if (pattern[x] == 3)
                {
                    //Yellow.transform.Rotate(Vector3.up, Time.deltaTime * 50, Space.World);
                    //pattern.Remove(x);
                    Yellow.GetComponent<Renderer>().material.color = Color.white;
                    yield return new WaitForSeconds(0.6f);
                    Yellow.GetComponent<Renderer>().material.color = Color.yellow;
                    yield return new WaitForSeconds(0.5f);
                    continue;

                }
            
                //yield return new WaitForSeconds(0.7f);
            }
        }
        play_Back = false;

    }

    public void testCorrect(int x)
    {
        Debug.Log(pattern.Count + "        dfsdfsdfdsfdsfsfsdfdsfdsfdsfdfds");
        if (play_Back == true) {

            counting = 1;
            pattern = new List<int>();
            SceneManager.LoadScene("BeatThatProtoLevel1");
        }
        if(pattern[onInList] != x)
        {
            
            counting = 1;
            pattern = new List<int>();
            SceneManager.LoadScene("BeatThatProtoLevel1");
        }
        else if (pattern[onInList]==x)
        {
            Debug.Log(pattern.Count + "            int " + x);
            onInList++;
            Debug.Log(pattern.Count +"    vs    oninlist: "    + onInList);
           if(onInList >= pattern.Count) {
                counting++;
                if(counting > 8)
                {
                    SceneManager.LoadScene("BeatThatProtoLevel2");
                }

                if(counting > 4 && counting < 9)
                {
                    SceneManager.LoadScene("NewBeatThatProto");
                }
                if( counting <= 4)
                {
                    SceneManager.LoadScene("BeatThatProtoLevel1");
                }
                //SceneManager.LoadScene("NewBeatThatProto");
           }
        }
       

    }
}
        
    
