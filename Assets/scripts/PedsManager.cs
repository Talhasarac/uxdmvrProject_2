using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedsManager : MonoBehaviour
{
    private List<Peds> _peds = new List<Peds>();
    private List<Peds> _removethisgyus = new List<Peds>();



findit finditt;
    public AudioSource _Scream;
    public AudioSource _Scream2;


public GameObject handleft;
    public GameObject handright;
    public float distance;
    private bool checkleft;

    void Start()
    {

finditt =  FindObjectOfType<findit>();
        foreach (var VARIABLE in FindObjectsOfType<Peds>())
        {
            _peds.Add(VARIABLE);
        }
    }

    
    void FixedUpdate()
    {

        if (checkleft)
        {
            int fornow = _peds.Count;

            for (int i = 0; i < _peds.Count; i++)
            {
                if (Vector3.Distance(handleft.transform.position,  _peds[i].transform.position) < distance)
                {
                    
                   if(!_peds[i].iamalreadzdedmf){

 finditt.addPoint(5);

                   }
                   
                        if (!_Scream.isPlaying)
                        {
                            _Scream.Play();
                            
                        }
                        else
                        {

                            if (!_Scream2.isPlaying)
                            {
                                _Scream2.Play();
                            }
                            
                        }
                   _peds[i].killthis();

                   removeMe(_peds[i]);
                    
                }
            }
               
            
            checkleft = false;
        }
        else
            {
                
                int fornow = _peds.Count;
                for (int i = 0; i < _peds.Count; i++)
                {
                    if (Vector3.Distance(handright.transform.position,  _peds[i].transform.position) < distance)
                    {
                      
                    if(!_peds[i].iamalreadzdedmf){

 finditt.addPoint(5);

                   }
                        _peds[i].killthis();
                        if (!_Scream.isPlaying)
                        {
                            _Scream.Play();
                            
                        }
                        else
                        {

                            if (!_Scream2.isPlaying)
                            {
                                _Scream2.Play();
                            }
                            
                        }
                        removeMe(_peds[i]);
                    
                    }
                }

                
                checkleft = true;
            }
        
    }

    public void removeMe(Peds peds)
    {
        _peds.Remove(peds);
    }
}
