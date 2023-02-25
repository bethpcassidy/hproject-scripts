using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public PlayerMovement character;
    static public int lineIndex;
    private int firstLine;
    public TextAsset textFile;
    string[] linesNew;



    // Start is called before the first frame update
    void Awake()
    {
        firstLine = 0;
        textComponent.text = string.Empty;
        // StartDialogue();
        linesNew = (textFile.text.Split('\n')); //splits text into array
        lineIndex = linesNew.Length;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            if (firstLine == 0)
            {
                StartDialogue();
                firstLine++;

            }

            if (textComponent.text == linesNew[lineIndex])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = linesNew[lineIndex];
            }
            // if(index == 0)
            // {
            //     Debug.Log("honk");
            // }
        }


    }

    void StartDialogue()
    {
        // Character.canMove = false;
        StartCoroutine(TypeLine());
        // lineIndex = 0;
    }

    IEnumerator TypeLine()
    {
        foreach (char c in linesNew[lineIndex].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (lineIndex < linesNew.Length - 1)
        {
            lineIndex++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
            Debug.Log("honk");
        }
        else
        {
            {
                textComponent.text = string.Empty;
                gameObject.SetActive(false);
                PlayerMovement.canMove = true;
            }
        }

    }

}