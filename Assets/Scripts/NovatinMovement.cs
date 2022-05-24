using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovatinMovement : MonoBehaviour
{
    Rigidbody2D rb;
    bool isJumping;
    public GameManager gameManager;
    AudioSource jumpSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
        jumpSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey("space") && isJumping == false)
        {
            rb.velocity = new Vector3(0, 25, 0);
            isJumping = true;
            jumpSound.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "obstacle")
        {
            gameManager.GameOver();
        }
    }
}
