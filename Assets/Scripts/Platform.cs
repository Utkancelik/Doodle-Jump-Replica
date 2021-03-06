using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float upForce = 10f;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb2D = collision.collider.GetComponent<Rigidbody2D>();
            
            if (rb2D != null)
            {
                Vector2 velocity = rb2D.velocity;
                velocity.y = upForce;
                rb2D.velocity = velocity;
            }
        }
        
        
    }

    





}
