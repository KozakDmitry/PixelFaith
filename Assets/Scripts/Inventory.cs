using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

//DICTIONARY or inside CELL
public enum type {Card, Usable }
public enum typeOfCard {Warrior, Samurai, Archer, Mage}
[Serializable]
public class Inventory :MonoBehaviour
{
    private GameObject test;
    private (InventoryCell, GameObject) gm;
    private Dictionary<int, (InventoryCell,GameObject)> inventory;
    private InventoryCell[] inventoryCapacity; 
    [SerializeField]
    private int countOfCells = 5;
    [SerializeField]
    private GameObject inventoryCell;
    [SerializeField]
    private GameObject inventoryScreen;
    private bool freeCells = true;
    private int checkedCells;
    public enum change
    {
        True,
        Change,
        False,
    }
    private bool IsHasFreeCells()
    {
        for (int i = 0; i < countOfCells; i++)
        {
            checkedCells = 0;
            if (!inventoryCapacity[i].getObject())
            {
                freeCells = true;
                break;
            }
            else
            {
                checkedCells++;
            }
            if (checkedCells == countOfCells - 1)
            {
                freeCells = false;
            }
        }
        return freeCells;
    }
    private void Start()
    {
        inventory = new Dictionary<int, (InventoryCell, GameObject)>();
        for (int i = 0; i < countOfCells; i++)
        {
            inventory.Add(i, (new InventoryCell(i), Instantiate(inventoryCell, inventoryScreen.transform)));
        }

        //inventoryCapacity = new InventoryCell[15];

        //for (int i = 0; i < countOfCells; i++)
        //{
        //    Instantiate(inventoryCell, inventoryScreen.transform);
        //    inventoryCapacity[i] = new InventoryCell(i);
        //}
    }
    public bool setCell(GameObject gameobj)
    {
        if (IsHasFreeCells())
        {
            for (int i = 0; i < countOfCells; i++)
            {
                if (!inventoryCapacity[i].getObject())
                {
                    
                    inventoryCapacity[i].setGameObj(gameobj);
                    return true;
                }

            }
            return false;
        }
        else
        {
            return false;
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
