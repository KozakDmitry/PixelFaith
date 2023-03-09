using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum type {Card, Usable }
public enum typeOfCard {Warrior, Samurai, Archer, Mage}
[Serializable]
public class Inventory :MonoBehaviour
{
    private InventoryCell[] inventoryCapacity; 
    [SerializeField]
    private int countOfCells = 5;
    [SerializeField]
    private GameObject inventoryCell;
    [SerializeField]
    private GameObject inventoryScreen;
    private bool freeCells = true;
    public enum change
    {
        True,
        Change,
        False,
    }
    public bool IsHasFreeCells()
    {
        return freeCells;
    }
    private void Start()
    {
        inventoryCapacity = new InventoryCell[15];
        
        for(int i = 0; i < countOfCells; i++)
        {
            Instantiate(inventoryCell, inventoryScreen.transform);
            inventoryCapacity[i] = new InventoryCell(i);
        }
    }
    public void setCell(GameObject gameobj)
    {
        for(int i = 0; i < countOfCells; i++)
        {
            if (inventoryCapacity[i].getObject())
            {
                inventoryCapacity[i].setGameObj(gameobj);
                break;
            }
            if (i == countOfCells - 1)
            {
                freeCells = false;
            }
        }
    }
    public InventoryCell giveCell(int num)
    {
        return inventoryCapacity[num];
    }
    public void OpenCloseInventory(change change)
    {
        switch (change)
        {
            case change.True:
                inventoryScreen.SetActive(true);
                break;
            case change.False:
                inventoryScreen.SetActive(false);
                break;
            case change.Change:
                inventoryScreen.SetActive(!inventoryScreen.activeInHierarchy);
                break;
            default:
                break;
        }

    }
    private void Save()
    {

    }
}
