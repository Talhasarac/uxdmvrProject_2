using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handcub : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BrickInactive"))
        {
            other.GetComponent<brick>().Activated();
        }

         if (other.CompareTag("PropInactive"))
        {
            Debug.Log("aaa bb cc");
            other.GetComponent<prop_phy>().Activated();
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
