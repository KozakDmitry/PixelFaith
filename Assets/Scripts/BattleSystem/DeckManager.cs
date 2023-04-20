using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour,IBattle
{

    [SerializeField]
    private GameObject cardPlacer;
    [SerializeField]
    private CardHolder[] cardsInHand;
    [SerializeField]
    private Inventory inventory;
    private CardDeck[] deck;
    private GameObject[] squad;
    private List<InventoryCell> cardList;
    private void Start()
    {
        cardList = new List<InventoryCell>();
    }
    
    public void StartBattle()
    {
        cardList = inventory.GetNeededObjects(type.Card);
        BuildADeck();
        FillHand();
    }

    private void FillHand()
    {
        for(int i = 0;i< cardsInHand.Length;i++)
        {
            cardsInHand[i] = SetCard(deck[i]);
        }
    }

    private CardHolder SetCard(CardDeck card)
    {
        return null;
    }
    private void BuildADeck()
    {
        deck = new CardDeck[cardList.Count * 4];
        int i = 0;
        foreach (InventoryCell cell in cardList)
        {
        List<CardDeck> cardTempInfo = cell.GetCardData().getSubCards();
            foreach (var cardInfo in cardTempInfo)
            {
                deck[i] = cardInfo;
                i++;
            }
        }
    }
    public void EndBattle()
    {

    }
}
