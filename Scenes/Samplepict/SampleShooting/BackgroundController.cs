﻿using System.Collections;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

  
    void Update()
    {
        Debug.Log("Back");
        transform.Translate(0, -0.03f, 0);
        if (transform.position.y < -4.9f)
        {
            transform.position = new Vector3(0, 4.9f, 0);
        }
    }
}
