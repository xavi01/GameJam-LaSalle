using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float speed;             
    private Rigidbody2D rb2d;       
    private int count;
    private bool ball;
    public GameObject pelota;
    public GameObject player2;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ball = false;
        pelota.SetActive(false);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
           transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
           transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (ball == true)
        {
            pelota.SetActive(true);
        }

        if (ball == false)
        {
            pelota.SetActive(false);
        }
    }


    public void setBall()
    {
        ball = false;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            ball = true;
            player2.gameObject.GetComponent<PlayerController2>().setBall();

        }
    }

}
