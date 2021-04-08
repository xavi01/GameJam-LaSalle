using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada1 : MonoBehaviour
{
    private int count;
    private bool ball;
    public GameObject pelota;
    public GameObject espada2;
    public GameObject espada_meva;

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
            espada_meva.gameObject.SetActive(false);
        }

        if (ball == false)
        {
            espada_meva.gameObject.SetActive(true);
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
            espada2.gameObject.GetComponent<Espada2Cntroller>().setBall();

        }

        if (collision.gameObject.CompareTag("Pelota"))
        {
            ball = true;
            collision.gameObject.SetActive(false);
        }
    }

}