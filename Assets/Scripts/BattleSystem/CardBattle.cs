using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBattle 
{
    [SerializeField]
    private int hp;
    [SerializeField]
    private int attackDamage;
    [SerializeField]
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
