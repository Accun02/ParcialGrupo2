using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHighScore : MonoBehaviour
{
    private string[] names = { "Juan", "Alejo", "Andre", "Dorothy", "Griddy", "Garcia" };
    private List<GameObject> gameObjectlist = new List<GameObject>();  
    public List<Player> listPlayers = new List<Player>();
    public GameObject prefabPlayerDisplay;
    public Transform layoutGroup;

    
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            int NamesIndex = Random.Range(0, names.Length);

            InsertPlayer(i + 1, names[NamesIndex], Random.Range(0, 1001));
        }
    }


    private void InsertPlayer(int id, string name, int score)
    {
        Player player =  new Player(id, name, score);
        listPlayers.Add(player);
        GameObject prefab = Instantiate(prefabPlayerDisplay, layoutGroup, true);
        PlayerHighScoreDisplay hsDisplay = prefab.GetComponent<PlayerHighScoreDisplay>();
        hsDisplay.Set(player.Id, player.Name, player.Score);
        gameObjectlist.Add(prefab);
    }


    private void AsendingShort()
    {

        var list = listPlayers.Count;
        for (int i = 0; i < list - 1; i++)
        {
            for (int j = 0; j < list - 1; j++)
            {
                if (listPlayers[j].Score > listPlayers[j + 1].Score)
                {
                    var tempVar = listPlayers[j].Score;
                    listPlayers[j].Score = listPlayers[j + 1].Score;

                    listPlayers[j + 1].Score = tempVar;

                }
            }
        }
    }

    private void DesendingShort()
    {
      

    }

    public void setShortasdes()
    {
        Debug.Log("funcaA");
        DesendingShort();
    }
    public void setShortasas()
    {
        Debug.Log("funcaB");
        AsendingShort();
     
    }
}

