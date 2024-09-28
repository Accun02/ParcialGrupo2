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

    public void ClearDisplay ()
    {
        foreach(var v in layoutGroup.GetComponentsInChildren<Transform>()) 
        {
            Destroy(v.gameObject);
        }
    }
    public void BubbleSort(bool descending)
    {
        ClearDisplay();
        bool swapped;
        int length = listPlayers.Count;
        print("sort " + length);
        do
        {
            swapped = false;
            for (int i = 0; i < length - 1; i++)
            {
                if (listPlayers[i].Score > listPlayers[i + 1].Score)
                {
                    // Swap elements
                    var temp = listPlayers[i];
                    listPlayers[i] = listPlayers[i + 1];
                    listPlayers[i + 1] = temp;

                    listPlayers[i].Id = i + 1;

                    swapped = true;
                }
            }
            length--; // Reduce the range of comparison
        } while (swapped);

        if (descending)
        {
            listPlayers.Reverse();
        }


    }
    public void InsertPlayer(int id, string nombre, int score)
    {
        Player p = new Player(id, nombre, score);
        listPlayers.Add(p);
        GameObject g = Instantiate(prefabPlayerDisplay, layoutGroup, true);
        PlayerHighScoreDisplay h = g.GetComponent<PlayerHighScoreDisplay>();
        h.Set(p.Id, p.Nombre , p.Score);
    }
}
public class Player
{
    private int id; //Creamos una variable de int numeros enteros
    private string nombre; // Creamos otra variable de string tipo textos
    private int score; // Creamos una variable de int numeros enteros

    public int Id { get => id; set => id = value; } //Propiedad que estan publicas exponen los valores internos de esta clase player
                                                    //Get permite que otras clases puedan ver el contenido de la variable id
                                                    //Set permite que otras clases puedan cambiar el contenido de la variable id
    public string Nombre { get => nombre; set => nombre = value; }
    public int Score { get => score; set => score = value; }

    public Player() // Es un constructor por defecto (no recive nada)
    {
        id = 0;
        nombre = "playerDefault";
        score = 0;
    }
    public Player(int id, string nombre, int score) //Es un constrcutor que recibe valores (parametrizado)
    {
        this.id = id;
        this.nombre = nombre;
        this.score = score;
    }
}