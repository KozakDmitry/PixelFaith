using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{

    [SerializeField]
    private Transform cameraPosition;
    [SerializeField]
    private Door[] doors;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.gameObject.GetComponent<TriggerManager>().ChangeCameraPosition(cameraPosition);         
        }
    }
    private void Awake()
    {
        
    }
    public void ChangeRoom(int numberOfRoom)
    {

    }
    
}
