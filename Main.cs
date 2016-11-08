using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    // Use this for initialization
    private GameObject Red;
    private GameObject Yellow;
    private GameObject Green;
    private GameObject Blue;
    private GameObject RestartButton;
    flashanimation2 flashfs = new flashanimation2();
    Transform countscore;
    Transform playerscore;
    public Main0 main0;

    private static int count;
    private static int score;

    int onInList = 0;
    static List<int> pattern;
    //static int countingCorrectPattern = 1;
    bool play_Back = false;

    void Start()
    {
        Debug.Log("starting beat my app main.");
        pattern = main0.getPattern();
        RestartButton = GameObject.Find("Canvas/Restart");
        RestartButton.SetActive(false);

        countscore = GameObject.Find("Canvas/CounterScore").transform;
        playerscore = GameObject.Find("Canvas/playerScore").transform;
        Debug.Log(main0.getScore());
        countscore.GetComponent<Text>().text = "Score: " + main0.getScore().ToString();

        Red = GameObject.Find("Canvas/Cubes/Red");
        Yellow = GameObject.Find("Canvas/Cubes/Yellow");
        Green = GameObject.Find("Canvas/Cubes/Green");
        Blue = GameObject.Find("Canvas/Cubes/Blue");
        //text =GameObject.Find("/Canvas/Score").GetComponent<Text>();
        //text.text = "score: " + pattern.Count.ToString();
        int r = Random.Range(0, 4);
        pattern.Add(r);

        //Debug.Log(pattern[0]);
        atart(flashfs.playBack(pattern, Red, Blue,Green,Yellow));

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
    public void notatart(IEnumerator coroutineMethod)
    {
        play_Back = true;
        UnityEngine.WSA.Application.InvokeOnAppThread(() =>
        {
            StopCoroutine(coroutineMethod);
        }, false);
        play_Back = false;
    }

   

    public void testCorrect(int x)
    {
        if(play_Back == true)
        {
            return;
        }
        if (pattern[onInList] == x)
        {
            onInList++;
            //countingCorrectPattern++;
            Debug.Log(main0.getCountCorrectPattern());
        }
        else
        {
            Debug.Log("you lose");
            score = count;
            playerscore.GetComponent<Text>().text = "Score: " + score.ToString();

            onInList = 0;
            main0.setReset();
            main0.resetScore();
            main0.resetpattern();
            pattern = new List<int>();
            Red = GameObject.Find("Canvas/Cubes/Red");
            Yellow = GameObject.Find("Canvas/Cubes/Yellow");
            Green = GameObject.Find("Canvas/Cubes/Green");
            Blue = GameObject.Find("Canvas/Cubes/Blue");
            RestartButton = GameObject.Find("Canvas/Restart");
            Red.SetActive(false);
            Blue.SetActive(false);
            Yellow.SetActive(false);
            Green.SetActive(false);
            RestartButton.SetActive(true);
            //StartCoroutine(playBack());
        }
        if(onInList >= pattern.Count && pattern.Count != 0)
        {

            main0.setScore();
            count = main0.getScore();
            Debug.Log("before");
            Debug.Log(count);
            //countscore = GameObject.Find("Canvas/CounterScore").transform;
            countscore.GetComponent<Text>().text = "Score: " + count.ToString();
            Debug.Log("after");
            Debug.Log(count);

            new WaitForSeconds(1);
            int r = Random.Range(0, 4);
            pattern.Add(r);
            onInList = 0;
            main0.setCountCorrectPattern();
            /*if(main0.getCountCorrectPattern() > 7)
            {
                SceneManager.LoadScene("BeatThatProtoLevel2");
            }*/
            SceneManager.LoadScene("BeatMyApp");
            //notatart(flashfs.playBack(pattern, Red, Blue,Green,Yellow));
            //atart(flashfs.playBack(pattern, Red, Blue,Green,Yellow));

        }
 
    }
}