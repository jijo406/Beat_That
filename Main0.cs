using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main0 : MonoBehaviour
{

    // Use this for initialization
    private GameObject Red;
    private GameObject Yellow;
    private GameObject Green;
    private GameObject Blue;
    private GameObject RestartButton;
    public Text text;

    int onInList = 0;
    static List<int> pattern = new List<int>();
    static int countingCorrectPattern = 1;
    bool play_Back = false;

    void Start()
    {
        RestartButton = GameObject.Find("Canvas/Restart");
        RestartButton.SetActive(false);

        Red = GameObject.Find("Canvas/Cubes/Red0");
        Blue = GameObject.Find("Canvas/Cubes/Blue0");
        if (countingCorrectPattern < 4)
        {
            int r = Random.Range(0, 2) * 2;
            Debug.Log("adding to the patterns" + r);
            pattern.Add(r);
        }

        Debug.Log("count of pattern " + pattern.Count);

        //Debug.Log(pattern[0]);
        StartCoroutine(playBack());

        // playBack();

    }

    // Update is called once per frame
    void Update()
    {



    }

    IEnumerator playBack()
    {
        play_Back = true;
        if (pattern != null)
        {
            for (int p = 0; p < pattern.Count; p++)
            {
                if (pattern[p] == 0)
                {
                   
                    Red.GetComponent<Renderer>().material.color = Color.white;
                    yield return new WaitForSeconds(0.6f);
                    Red.transform.GetComponent<Renderer>().material.color = Color.red;
               // tits transform.Rotate(Vector3.up, Time.deltaTime * 800, Space.World);
                    yield return new WaitForSeconds(0.3f);
                    
                    continue;
                }
              
                else if (pattern[p] == 2)
                {
                    Blue.GetComponent<Renderer>().material.color = Color.white;
                    yield return new WaitForSeconds(0.6f);
                    Blue.GetComponent<Renderer>().material.color = Color.blue;
                    yield return new WaitForSeconds(0.3f);
                    continue;
                }
              

                yield return new WaitForSeconds(0.7f);
            }
            play_Back = false;
        }
    }

    public void testCorrect(int x)
    {
        if (play_Back == true)
        {
            return;
        }
        if (pattern[onInList] == x)
        {
            onInList++;
            //countingCorrectPattern++;
            Debug.Log("counting correct pattern " + countingCorrectPattern);
            Debug.Log("oninlist " + onInList);
        }
        else
        {
            Debug.Log("you lose");
            onInList = 0;
            countingCorrectPattern = 1;

            pattern = new List<int>();
            Red.SetActive(false);
            Blue.SetActive(false);
            //Yellow.SetActive(false);
            //Green.SetActive(false);
            RestartButton.SetActive(true);
            //StartCoroutine(playBack());
        }
        if (onInList >= pattern.Count && pattern.Count != 0)
        {
            new WaitForSeconds(1);
            int r = Random.Range(0, 2)*2;
            pattern.Add(r);
            onInList = 0;
            countingCorrectPattern++;
            if(countingCorrectPattern >3)
            {
                SceneManager.LoadScene("BeatMyApp");
            }
            StartCoroutine(playBack());

        }

    }

    public int getCountCorrectPattern()
    {
        return countingCorrectPattern;
    }

    public void setCountCorrectPattern()
    {
        countingCorrectPattern++;
    }
    public void setReset()
    {
        countingCorrectPattern = 1;
    }
}