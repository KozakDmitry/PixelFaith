using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour,ICollectable
{
    public int id;
    [SerializeField]
    private int hp;
    [SerializeField]
    private int attackDamage;
    [SerializeField]
    private int defense;
    private List<Card> subCards;
    [SerializeField]
    private type type;
    [SerializeField]
    private CardData cardData;

    public Card(int id, int hp, int attackDamage, int defense, List<Card> subCards)
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

    public List<Card> GetSubCards()
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
