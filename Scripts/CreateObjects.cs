using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CreateObjects : MonoBehaviour
{
    public GameObject[] objects;
   private void FixedUpdate()
    {
        Instantiate(objects[Random.Range(0, objects.Length - 1)], new Vector3(RandNum(),RandNum(),RandNum()), Quaternion.Euler(RandNum(), RandNum(), RandNum()));
    }

    private int RandNum()
    {
        return Random.Range(0, 10);
    }
}
