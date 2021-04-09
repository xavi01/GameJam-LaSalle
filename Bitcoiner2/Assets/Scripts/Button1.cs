using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button1 : MonoBehaviour
{

    public void cambiarescena(string btc)
    {

        SceneManager.LoadScene(btc);

    }

}
