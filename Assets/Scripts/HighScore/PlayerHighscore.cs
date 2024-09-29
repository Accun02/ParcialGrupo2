using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHighScore : MonoBehaviour
{

    public enum ShortType //enum that funciontss as a simple StateMachine
    {
        Desending,
        Asending,
    }
    ShortType shortType = ShortType.Desending;
    public List<Player> listPlayers = new List<Player>();
    public GameObject prefabPlayerDisplay;
    public Transform layoutGroup;

    private string[] names = { "Juan", "Alejo", "Andre","Dorothy","Griddy","Garcia" };
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            int NamesIndex = names.Length - 1;
       
               int Selected = Random.Range(0, NamesIndex);
            

            InsertPlayer(i, names[Selected], Random.Range(0, 1001));
        }
    }


    private void InsertPlayer(int id, string nombre, int score)
    {
        Player p = new Player(id, nombre, score);
        listPlayers.Add(p);
        GameObject g = Instantiate(prefabPlayerDisplay, layoutGroup, true);
        PlayerHighScoreDisplay h = g.GetComponent<PlayerHighScoreDisplay>();
        h.Set(p.Id, p.Nombre, p.Score);
    }

    public void Shorts()
    {
        for (int i = 0; i < listPlayers.Count; i++) 
        {

            switch (shortType)
            {
                case ShortType.Desending:
                    DesendingShort();
                    break;

                case ShortType.Asending:
                    AsendingShort();
                    break;
            }
            
              
            
        }
      
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
        Shorts();

    }
    public void setShortasas()
    {

        shortType = ShortType.Asending;
        Shorts();

    }
}

