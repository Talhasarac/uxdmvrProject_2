using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prop_phy : MonoBehaviour
{
    Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


 public void Activated()
    {
     //   transform.tag = "PropActive";
      
        _rigidbody.isKinematic = false;
        _rigidbody.AddForce(4,0,0);
       // Invoke("Sleep",3f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
