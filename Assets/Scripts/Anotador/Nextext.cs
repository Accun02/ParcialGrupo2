using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class Nextext : MonoBehaviour
{
    private string insertedtext;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI Oldtext;
    private Stack<string> stack = new Stack<string>();
    [SerializeField] private Transform oldtexttrans; 
   

    bool CanWrite = false;

    private void Update()
    {
 
        Inputs();
        writing();
    }

    private void Inputs()
    {
        if (Input.GetKeyUp(KeyCode.Y))
        {

            CanWrite = true;

        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            CanWrite = false;
            moveText();        
        }            
    }

    private void moveText()
    {
        if (stack.Count > 0 && insertedtext != string.Empty) // cuando ya tiene un elemento en el stack
        {
             stack.Pop();
            stack.Push(insertedtext);   
            Oldtext.text = stack.Peek();

        }
        else if (stack.Count == 0 && insertedtext != string.Empty) // primera vez que se escribe
        {
            stack.Push(insertedtext);
            Oldtext.text = stack.Peek();

        }
        text.text = string.Empty;
        insertedtext = string.Empty;
    }

    private void writing()
    {
      
         if (CanWrite)
        {
            insertedtext += Input.inputString; //escribir texto
            text.text = insertedtext; 

        }

        
    }
        
}
