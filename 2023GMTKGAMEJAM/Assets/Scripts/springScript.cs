using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class springScript : MonoBehaviour
{
    public Animator anim;
    //public GameObject character;
    public float jumpForce = 20f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Character")
        {
            anim.SetBool("onSpring", true);
            
        }


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            anim.SetBool("onSpring", false);
        }

        if(collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if(rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                //rb.velocity = velocity;
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
