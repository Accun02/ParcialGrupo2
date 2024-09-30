using UnityEngine;

public class Player 
{
    private int id; //Creamos una variable de int numeros enteros
    private string name; // Creamos otra variable de string tipo textos
    private int score; // Creamos una variable de int numeros enteros

    public int Id { get => id; set => id = value; } //Propiedad que estan publicas exponen los valores internos de esta clase player
                                                    //Get permite que otras clases puedan ver el contenido de la variable id
                                                    //Set permite que otras clases puedan cambiar el contenido de la variable id
    public string Name { get => name; set => name = value; }
    public int Score { get => score; set => score = value; }

 
    public Player(int id, string name, int score) //Es un constrcutor que recibe valores (parametrizado)
    {
        this.id = id;
        this.name = name;
        this.score = score;
    }
}