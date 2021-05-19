using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class houseControl : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Col)
    {

        if (Col.gameObject.name == "Player")
        {
            SceneManager.LoadScene("GameWinScene");
        }
    }

}
