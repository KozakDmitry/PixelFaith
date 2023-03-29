using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardItem : MonoBehaviour,ICollectable
{
    public int id;
    [SerializeField]
    private int hp;
    [SerializeField]
    private int attackDamage;
    [SerializeField]
    private int defense;
    private List<CardItem> subCards;
    [SerializeField]
    private type type;
    [SerializeField]
    private CardData cardData;

    public CardItem(int id, int hp, int attackDamage, int defense, List<CardItem> subCards)
    {
        this.id = id;
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

    public type GetObjectType()
    {
        return type;
    }
    public CardData GetCardData()
    {
        return cardData;
    }
    public GameObject Collect()
    {

        Destroy(this.gameObject,0.1f);
        return this.gameObject;
    }
    public AdviceTypes InInteract()
    {
        return AdviceTypes.Usial;
    }
    public void OutInteract()
    {

    }
}
