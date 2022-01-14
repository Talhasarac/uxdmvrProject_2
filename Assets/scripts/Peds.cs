using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Peds : MonoBehaviour
{
    private Rigidbody[] _rigidbodys;
 public  bool iamalreadzdedmf;
    private Animator _animator;
    Collider[] _colds;
    private Test_script _testScript;
    private NavMeshAgent _navMeshAgent;
    private PedsManager _pedsManager;
    
    
    void Start()
    {
   
        _pedsManager = FindObjectOfType<PedsManager>();
        _animator = GetComponent<Animator>();
        _navMeshAgent = transform.parent.GetComponent<NavMeshAgent>();
        _testScript = transform.parent.GetComponent<Test_script>();
        _testScript = FindObjectOfType<Test_script>();
       // _rigidbodys = FindObjectsOfType<Rigidbody>();
_rigidbodys = GetComponentsInChildren<Rigidbody>();
        foreach (var VARIABLE in _rigidbodys)
        {
            VARIABLE.isKinematic = true;
        }
    }


    void rem()
    {
        _pedsManager.removeMe(this);
        
    }
    public void killthis()
    {

    

        if(iamalreadzdedmf)
return;



        GameObject parentto = transform.parent.gameObject;
      transform.SetParent(null);
      Destroy(parentto);
      
        _animator.enabled = false;
        foreach (var VARIABLE in _rigidbodys)
        {
            VARIABLE.isKinematic = false;
        }
        iamalreadzdedmf = true;
        Invoke("kinagain",2f);

       


    }


    void kinagain()
    {
        
        foreach (var VARIABLE in _rigidbodys)
        {
            VARIABLE.isKinematic = true;
        }

    }
    void Update()
    {
        
    }
}
