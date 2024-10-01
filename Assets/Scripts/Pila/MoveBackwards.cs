using UnityEngine;

public class MoveBackwards : Icommand
{
    float movevel = 1; //velocity between 
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
