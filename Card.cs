using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int cost;
    public int attack; //"power" in tutorial
    public int defense;
    public string cardDescription;



    public Card()
    {


    }

    public Card(int Id, string CardName, int Cost, int Attack, int Defense, string CardDescription)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        attack = Attack;
        defense = Defense;
        cardDescription = CardDescription;


    }
}
