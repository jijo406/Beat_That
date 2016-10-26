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
    private GameObject Blue;
    private GameObject RestartButton;
    private GameObject CounterScore;
    flashanimation flashfs = new flashanimation();

    //________________________
    //reggies counting score for display during game
    public Text countScore;
    public Text gameOver;
    private static int count;
    //_________________________

    static int onInList;
    static List<int> pattern = new List<int>();
    static int countingCorrectPattern = 1;
    bool play_Back = false;


    

    void Start()
    {
        RestartButton = GameObject.Find("Canvas/Restart");
        RestartButton.SetActive(false);

        

        //________________________________
        //count = 0;
        //countScore.text = "Count: " + count.ToString();
        //gameOver.text = "";
        //________________________________

        Red = GameObject.Find("Canvas/Cubes/Red0");
        CounterScore = GameObject.Find("Canvas/CounterScore");
        countScore = CounterScore.GetComponent<Text>();
        Blue = GameObject.Find("Canvas/Cubes/Blue0");
        if (countingCorrectPattern == 1)
        {
            int r = Random.Range(0, 2) * 2;
            Debug.Log("adding to the patterns" + r);
            pattern.Add(r);
        }

        Debug.Log("count of pattern " + pattern.Count);

        //Debug.Log(pattern[0]);
        //atart();
        atart(flashfs.playBack(pattern, Red, Blue));
        // playBack();

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void atart(IEnumerator coroutineMethod)
    {
        play_Back = true;
        UnityEngine.WSA.Application.InvokeOnAppThread(() =>
        {
            StartCoroutine(coroutineMethod);
        }, false);
        play_Back = false;
    }

    

   /* IEnumerator playBack()
    {
        Debug.Log("in playback");
        play_Back = true;
        while (pb) {
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
            pb = false;
        }
        
        play_Back = false;


    }*/

    public void testCorrect(int x)
    {
        Debug.Log("this is the value of onIntList" + onInList);
        Debug.Log("pattern to test: " + x);
        Debug.Log("this is the pattern on the list: " + pattern[onInList]);
        if (play_Back == true)
        {
            return;
        }
        if (pattern[onInList] == x)
        {
            Debug.Log("in pattern oninlist");
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
            //___________________________
            RestartButton.SetActive(true);
            gameOver.text = "Score: " + count.ToString();
            //___________________________

            //StartCoroutine(playBack());
        }


        if (onInList >= pattern.Count && pattern.Count != 0)
        {
            int r = Random.Range(0, 2)*2;
            pattern.Add(r);
            onInList = 0;
            countingCorrectPattern++;
            if(countingCorrectPattern >3)
            {
                Debug.Log("counting correct over 3 " + countingCorrectPattern);
                SceneManager.LoadScene("BeatMyApp");
            }
            
            else{
                Debug.Log("the number of correct pattern less than 4 " + countingCorrectPattern);

                //__________________________
                count = count + 1;
                Debug.Log("score "+ count);
                countScore.text = "Count: " + count.ToString();
                //__________________________

                SceneManager.LoadScene("level0");
                // atart(flashfs.playBack(pattern, Red, Blue));
                
            }   

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