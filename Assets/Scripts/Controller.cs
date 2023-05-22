using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float jumpForce = 1f;
    Rigidbody2D rb;
    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    } 

    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce);
    }
}
