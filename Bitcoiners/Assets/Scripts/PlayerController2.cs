using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    private int count;
    public GameObject pelota;
    private bool ball = false;
    public GameObject player1;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ball = false;
        pelota.SetActive(false);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
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


    public void setBall() {
        ball = false;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            ball = true;
            player1.gameObject.GetComponent<Player1Controller>().setBall();

        }
    }


}
