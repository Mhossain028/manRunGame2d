﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamra : MonoBehaviour
{
    private float speed = 3f; // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
            
    }
}
