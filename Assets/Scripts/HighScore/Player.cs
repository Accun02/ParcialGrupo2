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