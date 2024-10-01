using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEditor.ShortcutManagement;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class PlayerHighScore : MonoBehaviour
{
    private List<Player> players = new List<Player>();
    [SerializeField] private Player prefabScore;
    [SerializeField] private Player highScore;
    [SerializeField] private Transform parent;
    private string[] names = { "Juan", "Alejo", "Andre", "Dorothy", "Griddy", "Garcia" };

   
    private enum selectedDisplay
    {
        toptobottom,
        bottomtotop,
    }
    selectedDisplay  selectedisplay = selectedDisplay.toptobottom;
    private void Awake()
    {
        for (int i = 0; i < 10; i++)
        {
            int NameIndex = Random.Range(0, names.Length);

            AddPlayer(i.ToString(), names[NameIndex], Random.Range(1, 1000));
        }

    }

    private void AddPlayer(string number, string name, int score)
    {
        Player newplayer = Instantiate(prefabScore, parent);

        string scoreText = score.ToString();


        newplayer.SetText(number, name, scoreText);
        newplayer.SetValue(score);
        players.Add(newplayer);


    }

    public void SelectedAscendedShort()
    {
        selectedisplay = selectedDisplay.toptobottom;
        Shorting();
    }

    public void SelectedDesendedShort()
    {
      selectedisplay = selectedDisplay.bottomtotop;
        Shorting();
    }

    private void Shorting()
    {
        Player nextItem = null;
        int indexNext = -1;
        int numberSorted = 0;

        while (numberSorted < players.Count)
        {
            for (int i = 0; i < players.Count - numberSorted; i++)
            {
                Player currentItem = players[i];
                indexNext = i;

               

                        if (i != players.Count - numberSorted - 1)
                        {
                            indexNext = indexNext + 1;

                            nextItem = players[indexNext];
                            currentItem = players[i];

                            
                            switch (selectedisplay)
                            {
                            case selectedDisplay.toptobottom:
                             {
                                if (nextItem.Score > currentItem.Score)
                                {
                                    (players[indexNext], players[i]) = (players[i], players[indexNext]); //crea dos contrructores y los asigna
                                }

                                players[i].SetCurrentOrderNumber(parent, i);
                                players[indexNext].SetCurrentOrderNumber(parent, indexNext);
                             }
                            break;
                             case selectedDisplay.bottomtotop:
                               {

                                if (nextItem.Score < currentItem.Score)
                                {
                                    (players[indexNext], players[i]) = (players[i], players[indexNext]);
                                }

                                players[i].SetCurrentOrderNumber(parent, i);
                                players[indexNext].SetCurrentOrderNumber(parent, indexNext);
                               }
                            break;
                              }

                          
                        }
                  
              
                else
                {
                    numberSorted++;
                }
            }
        }
    }
}

 





