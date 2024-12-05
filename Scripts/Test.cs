using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        print("Start");
    }
    
    void Update()
    {
        print("Update");
    }

    private void FixedUpdate()
    {
        print("Fixed update");
    }

    private void Awake()
    {
        print("Awake");
    }

    private void LateUpdate()
    {
        print("Late update");
    }

    private void OnDestroy()
    {
        print("Destroy");
    }

    private void OnEnable()
    {
        print("OnEnable");
    }

    private void OnDisable()
    {
        print("OnDisable");
    }
}
