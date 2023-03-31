using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CardBattle 
{
    private int hp;
    private int attackDamage;
    
    private int defense;
    
    private List<CardItem> subCards;

    public CardBattle(int hp, int attackDamage, int defense, List<CardItem> subCards)
    {

        this.hp = hp;
        this.attackDamage = attackDamage;
        this.defense = defense;
        this.subCards = subCards;
    }
    public int GetHp()
    {
        return hp;
    }

    public int GetAttackDamage()
    {
        return attackDamage;
    }

    public int GetDefense()
    {
        return defense;
    }

    public List<CardItem> GetSubCards()
    {
        return subCards;
    }

}
