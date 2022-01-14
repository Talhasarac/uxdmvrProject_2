using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingShell : MonoBehaviour
{
    public GameObject[] childs;
    void Start()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HAND"))
        {
            Debug.Log("HAND DETECTED");
            foreach (var VARIABLE in childs)
            {
                VARIABLE.SetActive(true);
            }
            gameObject.SetActive(false);

        }
    }

    void Update()
    {
        
    }
}
