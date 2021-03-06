using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada1Controller : MonoBehaviour
{

    private int count;
    private bool ball;
    public GameObject pelota;
    public GameObject player2;
    public GameObject espada2;

    void Start()
    {
        ball = false;
        pelota.SetActive(false);
    }

    void FixedUpdate()
    {

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
        if (collision.gameObject.CompareTag("Pelota2"))
        {
            ball = true;
            espada2.gameObject.GetComponent<Espada1Controller>().setBall();

        }

        if (collision.gameObject.CompareTag("Pelota"))
        {
            ball = true;
            collision.gameObject.SetActive(false);
        }
    }

}
