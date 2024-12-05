using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLight : MonoBehaviour
{
    private Light _mainLight;
    void Awake()
    {
        _mainLight = GetComponent<Light>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _mainLight.enabled = !_mainLight.enabled;
    }
}
