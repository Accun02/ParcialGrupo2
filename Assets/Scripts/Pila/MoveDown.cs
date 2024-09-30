using UnityEngine;

public class MoveDown : Icommand
{
    float movevel = 1; //velocity between 
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
