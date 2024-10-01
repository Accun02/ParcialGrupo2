using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class QuestManager : MonoBehaviour
{
    private Queue <GameObject> missionQueue = new Queue <GameObject> ();
    [SerializeField] private GameObject[] quests; // array que guarda las primeras instancias de las quest
    private GameObject currentMission;
    bool newQuest = true;
    [SerializeField] private GameObject noquest;
    [SerializeField] private Transform questpos; //que se quede centrada en pantalla
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < quests.Length; i++)  //Guarda las quest en la cola
        {
            missionQueue.Enqueue(quests[i]);         
        }
        missionQueue.TryPeek(out GameObject newquest); //se fija;
        currentMission = Instantiate( newquest, questpos );   //se intancia y se guarda en el gameobject current mission
    }

    // Update is called once per frame
     public void FinishQuest()
    {
       
       
        missionQueue.TryDequeue(out GameObject finishMission); //se fija si hay un objeto

        if (finishMission != null)
        {
            Destroy(currentMission); // destruye la mision actual
        }
        nextquest();

      
    }

    private void nextquest()
    {
        if (missionQueue.Count > 0)
        {
            missionQueue.TryPeek(out GameObject newquest); //se fija si hay nuevas
            currentMission = Instantiate(newquest, questpos); // la intancia
        }

        else
        {

            if (newQuest == true)
            {
                currentMission = Instantiate(noquest, questpos);
                newQuest = false;
            }

        }
    }
}
