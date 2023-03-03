using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    private int[] sides;
    [SerializeField]
    private GameObject standartRoom;
    [SerializeField]
    private ScriptableObject mapStats;
    private Vector3 startPosition = new Vector3(0, 0, 0);
    private enum pointsOfRoom
        {
            left = 0,
            top = 1,
            right = 2,
            bottom = 3
        }

    private void Start()
    {
        sides = new int[4];   
    }
    private void GenerateMap()
    {
        for(int i = 0; i < 4; i++)
        {
            Instantiate(standartRoom);
        }

    }
}
