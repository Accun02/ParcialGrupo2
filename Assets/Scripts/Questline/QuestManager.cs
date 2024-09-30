using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class QuestManager : MonoBehaviour
{
    private Queue <GameObject> missionQueue = new Queue <GameObject> ();
    [SerializeField] private GameObject[] quests;

    [SerializeField] private Transform questpos;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < quests.Length; i++) 
        {
            missionQueue.Enqueue(quests[i]);
       
        }
      
        
        missionQueue.TryPeek(out GameObject newquest);
        Instantiate( newquest, questpos );

        
    }

    // Update is called once per frame
     public void FinishQuest()
    {
        if (missionQueue.TryDequeue(out GameObject finishdmission))
        {
            Destroy(finishdmission);
        }
     

        missionQueue.TryPeek(out GameObject newquest);
        Instantiate( newquest, questpos );

     
    }
}
