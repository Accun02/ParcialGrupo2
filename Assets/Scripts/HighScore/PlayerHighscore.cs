using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHighScore : MonoBehaviour
{

  private  enum ShortType //enum that funciontss as a simple StateMachine
    {
        Desending,
        Asending,
    }
   private  ShortType shortType = ShortType.Desending;
    private string[] names = { "Juan", "Alejo", "Andre", "Dorothy", "Griddy", "Garcia" };

    public List<Player> listPlayers = new List<Player>();
    public GameObject prefabPlayerDisplay;
    public Transform layoutGroup;

    
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            int NamesIndex = Random.Range(0, listPlayers.Count);

          
            

            InsertPlayer(i, names[NamesIndex], Random.Range(0, 1001));
        }
    }


    private void InsertPlayer(int id, string nombre, int score)
    {
        Player p = new Player(id, nombre, score);
        listPlayers.Add(p);
        GameObject g = Instantiate(prefabPlayerDisplay, layoutGroup, true);
        PlayerHighScoreDisplay h = g.GetComponent<PlayerHighScoreDisplay>();
        h.Set(p.Id, p.Name, p.Score);
    }

     
    private void AsendingShort()
    {
      
    }

    private void DesendingShort()
    {
        throw new System.NotImplementedException();
    }

    public void setShortasdes()
    {
        
        shortType = ShortType.Desending;
    DesendingShort();

    }
    public void setShortasas()
    {

        shortType = ShortType.Asending;
      AsendingShort();

    }
}

