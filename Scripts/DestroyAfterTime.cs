using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Default Destruction Time")]
    public float timeToDistruction;

    void Start()
    {
        Invoke("DestroyObject", timeToDistruction);
    }

    void Update()
    {

    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}

