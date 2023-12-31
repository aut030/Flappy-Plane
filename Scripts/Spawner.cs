﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spikes Objects for controlling the game")]
    public GameObject spikes;
    [Header("Default Height")]
    public float height;

    void Start()
    {
        InvokeRepeating("InstantiateObjects", 1f, 1f);
    }

    void Update()
    {
        transform.position = new Vector3(5, Random.Range(-height, height), 0);
    }

    void InstantiateObjects()
    {
        Instantiate(spikes, transform.position, transform.rotation);
    }
}
