using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball1Player : MonoBehaviour
{
    private int golsPlayer1;
    public Text gols1text;
    public GameObject player1;
    public GameObject player2;

    void Start()
    {
        golsPlayer1 = 0;
        gols1text.text = "Player 1 - 0";
        
    }

   
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Porteria2"))
        {
            golsPlayer1++;
            gols1text.text = "Player 1 - " + golsPlayer1;
            player1.transform.position = new Vector3 (-6, 0, 0);
            player2.transform.position = new Vector3( 6, 0, 0);
            player1.gameObject.GetComponent<Player1Controller>().setBall();
        }
    }
}
