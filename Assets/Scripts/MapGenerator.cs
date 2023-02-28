using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject standartMap;
    [SerializeField]
    private ScriptableObject mapStats;
    private enum pointsOfRoom
        {
            left = 0,
            top = 1,
            right = 2,
            bottom = 3
        }

}
