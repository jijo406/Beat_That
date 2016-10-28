using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SpeechManager : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer = null;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    // Use this for initialization
    void Start()
    {
        /* To select the cube, send message upwards Click action cs and then that calls Blue script to test the pattern. 
           Not too sure where to actually put this.  On individual cubes or on each cube? TBD. */
        keywords.Add("Select", () =>
        {
            var focusObject = GazeGestureManager.Instance.FocusedObject;
            if (focusObject != null)
            {
                // Call the OnDrop method on just the focused object.
                focusObject.SendMessage("onSelect");
            }
        });
        
        keywords.Add("Select red", () => 
        {
            this.BroadcastMessage("onRed");
        });
        
        keywords.Add("Select blue", () => 
        {
            this.BroadcastMessage("onBlue");
        });
          
        keywords.Add("Select green", () => 
        {
            this.BroadcastMessage("onGreen");
        });
      
        keywords.Add("Select yellow", () => 
        {
            this.BroadcastMessage("onYellow");
        });
        // Maybe add something that lets you quit the game all together. 
        keywords.Add("Quit game", () =>
        {
            Application.Quit();
        });
        

        // Tell the KeywordRecognizer about our keywords.
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());

        // Register a callback for the KeywordRecognizer and start recognizing!
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }
}
