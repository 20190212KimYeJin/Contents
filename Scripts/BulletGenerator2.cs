using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator2 : MonoBehaviour
{
    public GameObject blPrefab2;
    float span = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime * 0.5f;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(blPrefab2) as GameObject;
            go.transform.position = new Vector3(-6.9f, 0.9f, 0);
        }
    }
}
