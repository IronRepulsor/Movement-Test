﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    [SerializeField]
    KeyCode CameraLeft;
    [SerializeField]
    KeyCode CameraRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(CameraLeft))
        {
            transform.Rotate(new Vector3(0, 10, 0));
        } 
    }
}
