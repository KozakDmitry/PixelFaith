using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{

    [SerializeField]
    private Transform cameraPosition;
    public GameObject[] doors;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            collision.gameObject.GetComponent<TriggerManager>().ChangeCameraPosition(cameraPosition);         
        }
    }
    
    public void ChangeRoom(int numberOfRoom)
    {

    }
    
}
