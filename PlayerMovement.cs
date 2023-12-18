using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;//physics object
    private Animator ani;
    private SpriteRenderer sprite;
    private float dirX = 0;
    //int wholeNumber = 16;

    void Start()  // Start is called before the first frame update
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();

       // Debug.Log("Hello, world!");
    }

    void Update()// Update is called once per frame
    {
       float dirX = Input.GetAxisRaw("Horizontal");

       rb.velocity = new Vector2( dirX* 10f, rb.velocity.y);//xy block  sprite.flipX = true;

        if (Input.GetButtonDown("Jump")) //jump block
        {
            rb.velocity = new Vector2(0, 17f);
            ani.SetBool("jumping", true);
        }
        else { ani.SetBool("jumping", false); }
        
        
        
        UpdateAnimationUpdate();
    }

    private void UpdateAnimationUpdate()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        if (dirX > 0f)
        {
            ani.SetBool("running", true);
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            ani.SetBool("running", true);
            sprite.flipX = true;
        }
        else
        {
            ani.SetBool("running", false);
        }

    }
}
