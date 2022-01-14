using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour
{
 private Rigidbody _rigidbody;
 private BrickManager _brickManager;
   private bool sleep;
   private Vector3 lastSpeed;


   private BoxCollider normalwone;
   private bool somethinginspace;
   private BoxCollider _triggerOne;
    void Awake()
    {
        _brickManager = FindObjectOfType<BrickManager>();
        _rigidbody = GetComponent<Rigidbody>();
        gameObject.SetActive(false);
        
        normalwone = GetComponent<BoxCollider>();

            _triggerOne =  gameObject.AddComponent<BoxCollider>();
       _triggerOne.isTrigger = true;
       _triggerOne.center = normalwone.center;
       _triggerOne.size = normalwone.size * 1.05f;
       
       _triggerOne.enabled = false;

       normalwone.enabled = false;
     MeshCollider mc =  gameObject.AddComponent<MeshCollider>();
     mc.convex = true;
    }

    public void Activated()
    {
        transform.tag = "BrickActive";
        _brickManager.add(this);
        _rigidbody.isKinematic = false;
        _triggerOne.enabled = true;
        // Invoke("Sleep",3f);

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BrickInactive"))
        {
            somethinginspace = true;
        }
        
        
    }


    public void Sleep()
    {
        if (!sleep)
        {

            

            if (_rigidbody.velocity.magnitude > 0.05f)
            {
                
                Debug.Log("buyuktu");
                lastSpeed = _rigidbody.velocity;
                _rigidbody.isKinematic = true;
                sleep = true;
                
                
            }
            else
            {
                if (somethinginspace)
                {
                    Debug.Log("kucuktu");
                    transform.tag = "BrickInactive";
                    _brickManager.remove(this);
                    _rigidbody.isKinematic = true;
                    somethinginspace = false;
                    

                }
                else
                {
                    
                    Debug.Log("buyuktu");
                    lastSpeed = _rigidbody.velocity + new Vector3(0,-0.1f,0);
                    _rigidbody.isKinematic = true;
                    sleep = true;
                }
                
                
            
                
                
                
            }
            


        }
            

    }
    // Update is called once per frame
    void Update()
    {
        if (sleep)
        {

            if (transform.position.y > 0.1f)
            {
                transform.Translate(new Vector3(lastSpeed.x,-Mathf.Abs(lastSpeed.y)-0.01f,lastSpeed.z),Space.World);
                if (_triggerOne.enabled)
                {
                    _triggerOne.enabled = false;
                }
                
            }
            else
            {
                this.enabled = false;


            }
            
            
        }   
        
    }
}
