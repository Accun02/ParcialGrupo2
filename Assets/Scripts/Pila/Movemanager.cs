using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Movemanager : MonoBehaviour
{
  
 
}
public class MoveFoward : Icommand
{
    float movevel = 1.5f; //velocity between 
    Vector3 Lastpos;
    private PlayerControls playerControls;
    public MoveFoward(PlayerControls playerControls)
    {
        this.playerControls = playerControls;
    }

 
    public void Execute()
    {
        Lastpos = playerControls.transform.position;
        playerControls.transform.position += new Vector3(movevel, 0, 0); //moves character in x
        
    }

    public void Undo()
    {
     playerControls.transform.position = Lastpos;
    }
}

public class MoveBackwards : Icommand
{
    float movevel = 1.5f; //velocity between 
    Vector3 Lastpos;
    private PlayerControls playerControls;
    public MoveBackwards(PlayerControls playerControls)
    {
        this.playerControls = playerControls;
    }


    public void Execute()
    {
        Lastpos = playerControls.transform.position;
        playerControls.transform.position -= new Vector3(movevel, 0, 0); //moves character in x
   

    }

    public void Undo()
    {
        playerControls.transform.position = Lastpos;
    }
}
public class MoveUp : Icommand
{
    float movevel = 1.5f; //velocity between 
    Vector3 Lastpos;
    private PlayerControls playerControls;
    public MoveUp(PlayerControls playerControls)
    {
        this.playerControls = playerControls;
    }


    public void Execute()
    {
        Lastpos = playerControls.transform.position;
        playerControls.transform.position += new Vector3( 0, movevel, 0); //moves character in x


    }

    public void Undo()
    {
        playerControls.transform.position = Lastpos;
    }
}
public class MoveDown : Icommand
{
    float movevel = 1.5f; //velocity between 
    Vector3 Lastpos;
    private PlayerControls playerControls;
    public MoveDown(PlayerControls playerControls)
    {
        this.playerControls = playerControls;
    }


    public void Execute()
    {
        Lastpos = playerControls.transform.position;
        playerControls.transform.position -= new Vector3(0, movevel, 0); //moves character in Y
      


    }

    public void Undo()
    {
        playerControls.transform.position = Lastpos;
    }
}
