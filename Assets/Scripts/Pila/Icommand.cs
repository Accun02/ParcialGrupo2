using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Icommand 
{
   

  public void Execute();
  public  void Undo(); //undo an action
}
