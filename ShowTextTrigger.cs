using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowTextTrigger : MonoBehaviour
{
    public PlayerMovement character;
    public GameObject Object;
    public GameObject DialogueBox;
    public GameObject ActivateObject;
    // public TextAsset TextFileAsset;


    // Start is called before the first frame update

    void Start()
    {
        Object.SetActive(false);
        DialogueBox.SetActive(false);
    }

    void OnTriggerEnter()
    {
        PlayerMovement.canMove = false;
        Object.SetActive(true);
        DialogueBox.SetActive(true);
        Dialogue.lineIndex = 0;

    }


    // private void ReadTextFile()
    // {
    //     string txt = TextFileAsset.etxt;
    //     string[] lines = txt.Split(System.Environment.NewLine.ToCharArray());
    //      foreach (string line in lines) 
    //     {
    //         if (!string.IsNullOrEmpty(line) )/
    //         {
    //             dialogue.Enqueue(line); 
    //         }
    //     }
    //     dialogue.Enqueue("EndQueue");
    // }
    // dialogue.Start


    void OnTriggerExit()
    {
        ActivateObject.SetActive(true);
        Dialogue.lineIndex = 0;
        // Object.SetActive(false);

    }


}