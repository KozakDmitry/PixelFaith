using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    private int[] sides;
    [SerializeField]
    private GameObject standartRoom;
    [SerializeField]
    private ScriptableObject mapStats;
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
            sides[i] = Random.Range(0, 4);
        }

    }
}
