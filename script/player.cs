using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;
    public Animator animator;

    float speedAmount = 5f;
    float JumpAmount = 9f;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
       transform.position += velocity * speedAmount * Time.deltaTime;
       animator.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));

      /* if (Input.GetButtonDown("Jump") && !animator.GetBool("isJumping"))
       {
           rgb.AddForce(Vector3.up * JumpAmount, ForceMode2D.Impulse);
           animator.SetBool("isJumping", true);
       }*/
       //deneme
        if (Input.GetKeyDown(KeyCode.W) && !animator.GetBool("isJumping"))
       {
           rgb.AddForce(Vector3.up * JumpAmount, ForceMode2D.Impulse);
           animator.SetBool("isJumping", true);
       }
        if (Input.GetKeyDown(KeyCode.S) && animator.GetBool("isJumping"))
       {
           animator.SetBool("isJumping", false);
       }

       //sağ sol dönme
       if (Input.GetAxisRaw("Horizontal") == -1)
       {
           transform.rotation = Quaternion.Euler(0f,180f, 0f);
       }
         else if (Input.GetAxisRaw("Horizontal") == 1)
       {
           transform.rotation = Quaternion.Euler(0f, 0f, 0f);
       }
    //çift zıp deactive
    }
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.name == "obje")
        {
            animator.SetBool("isJumping", false);
        }
    }
     private void OnCollisionExit2D(Collision2D Collision)
    {
        if (Collision.gameObject.name == "obje")
        {
            animator.SetBool("isJumping", true);
        }
    }
}