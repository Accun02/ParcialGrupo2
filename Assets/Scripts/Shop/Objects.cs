using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects 
{
    string? name;
    string[] type; //["Weapon", "Armor", "Accesory", "Item"];
    int Price;

    public Objects(string Names, string[] Types, int Prices)
    {
        this.name = Names;
        this.type = Types;
        this.Price = Prices; 
    }
}
