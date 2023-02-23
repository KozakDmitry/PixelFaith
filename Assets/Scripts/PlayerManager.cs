using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 5f;
    private Inventory inventory;
    private Rigidbody2D rb;


    private Vector2 moveInput;
    void Start()
    {
        inventory = GetComponent<Inventory>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.MovePosition(rb.position + moveInput.normalized * movementSpeed * Time.deltaTime);
    }
    void Update()
    {
        
    }
}
