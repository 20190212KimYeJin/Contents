﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.02f, 0, 0);

        if (transform.position.x > 10.0f)
        {
            Destroy(gameObject);
        }
    }
}