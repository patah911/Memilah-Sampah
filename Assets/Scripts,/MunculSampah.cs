using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculSampah : MonoBehaviour
{
 public float jeda = 0.8f;
 float timer;
 public GameObject[] obyekSampah;
 // Use this for initialization
 void Start()
    {
     }
 // Update is called once per frame
 void Update()
    {
        timer += Time.deltaTime;
         if (timer > jeda)
             {
             int random = UnityEngine.Random.Range(0, obyekSampah.Length);
            Instantiate(obyekSampah[random], transform.position, transform.rotation);
           timer = 0;
             }
         }
 }
