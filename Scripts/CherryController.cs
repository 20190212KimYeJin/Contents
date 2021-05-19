using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    //public GameObject acPrefab;

    void OnTriggerEnter2D(Collider2D Col)
    {

        GameObject sc = GameObject.Find("Score");

        if (Col.gameObject.name == "Player")
        {
            sc.GetComponent<scoreControl>().AddScore();
            Destroy(gameObject);
        }
    }
}