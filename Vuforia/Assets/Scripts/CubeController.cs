﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Vector3 RotateVector;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateVector * Time.deltaTime);
    }
}