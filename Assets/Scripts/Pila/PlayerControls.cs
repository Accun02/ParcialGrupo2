using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    float movevel = 1.5f; //velocity between 
    public Stack<Icommand> charactmov = new Stack<Icommand>();
    private void Update()
    {
        Inputs();
    }

    private void Inputs()
    {
       if (Input.GetKeyDown(KeyCode.D)) 
        {

            Icommand movefoward = new MoveFoward(this);
            movefoward.Execute();
        charactmov.Push(movefoward);//saves position in stack
     
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Icommand moveBackwards = new MoveBackwards(this);
            moveBackwards.Execute();
            charactmov.Push(moveBackwards);//saves position in stack
          
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Icommand moveUp = new MoveUp(this);
            moveUp.Execute();
            charactmov.Push(moveUp);//saves position in stack
        
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Icommand moveDown = new MoveDown(this);
            moveDown.Execute();
            charactmov.Push(moveDown);//saves position in stack
   
        }
        if (Input.GetKeyDown(KeyCode.R)) 
        {
       Icommand lastpos = charactmov.Pop(); //saves the last position before being deleted from the stack

            lastpos.Undo(); //Executes method, sending the last position from the stack
        }
    }
}