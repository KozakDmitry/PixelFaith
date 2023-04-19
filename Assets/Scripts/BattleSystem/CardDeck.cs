using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CardDeck 
{
    
    [SerializeField]
    private string name;
    [SerializeField]
    private int attack;
    [SerializeField]
    private int cost;
    

    public CardDeck(string name,int attack,int cost)
    {
        this.name = name;
        this.attack = attack;
        this.cost = cost;
    }


    public string getName() { return name; }
    public int getAttack() { return attack; }
    public int getCost() { return cost; }

}
