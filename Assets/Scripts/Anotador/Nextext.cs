using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Nextext : MonoBehaviour
{
    private string insertedtext;
    [SerializeField] private TextMeshProUGUI text;
    Stack<string> stack = new Stack<string>();
    // Start is called before the first frame update

    bool CanWrite = false;

    private void Awake()
    {
        Instantiate(text);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
           
           CanWrite = true;
     
          
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (stack.Count > 0) 
            {
                stack.Pop();
            }
            stack.Push(insertedtext);

         
   
        }
        writing();
    }

    private void writing()
    {
        while (CanWrite)
            {

            insertedtext += Input.inputString;

            text.text = insertedtext;
        }
    }
        
}
