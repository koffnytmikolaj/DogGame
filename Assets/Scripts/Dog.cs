using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    AudioSource audioSource;
    public AudioClip jumpSound;

    private readonly float jumpPower = 4000f;
    public bool jump = false;
    private bool didJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        anim.SetBool("jump", jump);
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0) && !jump)
        {
            if(!didJump) audioSource.PlayOneShot(jumpSound);
            didJump = true;
            Vector2 force = Vector2.up * jumpPower * Time.deltaTime * rb.mass * rb.gravityScale;
            rb.AddForce(force);
        }
        if (jump && rb.position.y < -2.801614) didJump = false;
        jump = rb.position.y >= -2.801614;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstacle"))
        {
            Debug.Log("X");
        }
    }
}
