using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private int numberOfSide;
    [SerializeField]
    private RoomManager roomManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            roomManager.ChangeRoom(numberOfSide);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
