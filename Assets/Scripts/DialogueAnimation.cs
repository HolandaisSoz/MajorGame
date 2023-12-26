using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialogueAnimation : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public string text;
    public int strCounter,timer;
    public bool isFinished;

    // Start is called before the first frame update
    void Start()
    {
        strCounter = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (strCounter < text.Length && isFinished == false)
        {
            timer++;
            if (timer == 10)
            {
                strCounter++;
                timer = 0;
            }
            textMesh.text = text.Substring(0, strCounter);

        }
        if(text.Length == strCounter && isFinished == false)
        {
            isFinished = true;
            strCounter = 0;
        }

    }
   
}

