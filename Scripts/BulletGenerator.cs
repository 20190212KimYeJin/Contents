using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject blPrefab;
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
            GameObject go = Instantiate(blPrefab) as GameObject;
            go.transform.position = new Vector3(6, -1.9f, 0);
        }
    }
}
