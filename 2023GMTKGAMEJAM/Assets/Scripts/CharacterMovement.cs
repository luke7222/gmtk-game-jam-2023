using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    public float movespeed = 8f;
    public float jumpForce = 5f;
    public bool isFacingRight = true;
    public int turn = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("Collision with wall");
            turn = turn * -1;
        }
        if (collision.gameObject.tag == "Jumper")
        {
            Debug.Log("Collision with Jumper");
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            Debug.Log("Jumped");
            

        }
        

    }

    private void Awake()
    {
        Debug.Log("Awake");
        rb = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {

        rb.velocity = new Vector2(turn * movespeed, rb.velocity.y);
    }
}
