using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleScene : MonoBehaviour
{
    
  public void ChangePuzzle()
    {
        SceneManager.LoadScene("Puzzle");
    }

    public void ChangeInventoy()
    {
        SceneManager.LoadScene("Inventory");
    }

    public void ChangeQuestline()
    {
        SceneManager.LoadScene("Questline");
    }
}
