using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHighScoreDisplay : MonoBehaviour
{
    public TMPro.TextMeshProUGUI IDDisplay;
    public TMPro.TextMeshProUGUI nameDisplay;
    public TMPro.TextMeshProUGUI scoreDisplay;

    public void Set(int id, string name, int score)
    {
        IDDisplay.text = id.ToString();
        nameDisplay.text = name.ToString();
        scoreDisplay.text = score.ToString();
    }
}
