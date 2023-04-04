using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour,IBattle
{
    [SerializeField]
    private Inventory inventory;
    private GameObject[] deck;
    private GameObject[] squad;
    private List<InventoryCell> cardList;
    private void Start()
    {
        cardList = new List<InventoryCell>();
        
    }
    
    public void StartBattle()
    {
        cardList = inventory.GetNeededObjects(type.Card);
        
    }
    private void BuildADeck()
    {

    }
    public void EndBattle()
    {

    }
}
