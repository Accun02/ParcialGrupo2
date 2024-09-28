using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHighScore : MonoBehaviour
{


    public List<Player> listPlayers = new List<Player>();
    public GameObject prefabPlayerDisplay;
    public Transform layoutGroup;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            InsertPlayer(i, "playerDefault" + i, Random.Range(0, 1001));
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

    public void DescendingShort()
    {
        for (int i = 0; i < listPlayers[i].Score; i++)
        {
            for (int j = 0; j < listPlayers.Count - 1; j++)
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
}

