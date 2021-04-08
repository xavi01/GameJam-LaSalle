using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball2Player : MonoBehaviour
{
    private int golsPlayer2;
    public Text gols2text;
    public GameObject player1;
    public GameObject player2;
    public GameObject espada2;
    public GameObject pelota_medio;

    void Start()
    {
        golsPlayer2 = 0;
        gols2text.text = "0 - Player 2";
    }


    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Porteria1"))
        {
            golsPlayer2++;
            gols2text.text = golsPlayer2 + " - Player 2";
            player1.transform.position = new Vector3(-6, 2, 0);
            player2.transform.position = new Vector3(5, 2, 0);
            espada2.gameObject.GetComponent<Espada2Cntroller>().setBall();
            pelota_medio.SetActive(true);

        }
    }
}
