using TMPro;
using UnityEngine;

public class Player :MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI idText;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI scoreText;

    public TextMeshProUGUI ScoreText { get { return scoreText; } }
    int score;
    int id;

    public int Score => score;


    public void SetText(string number, string name, string score)
    {
        nameText.text = name;
        scoreText.text = score;
        idText.text =  (transform.GetSiblingIndex() + 1).ToString();
    }
    public void SetValue(int Score)
    { 
    
        this.score = Score;
    }
    public void SetCurrentOrderNumber(Transform parent, int index)
    {
        transform.SetSiblingIndex(index);
        idText.text = (transform.GetSiblingIndex() + 1).ToString();
    }
}