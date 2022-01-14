using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    public List<brick> _Bricks = new List<brick>();

    findit finditt;
    void Start()
    {
        finditt =  FindObjectOfType<findit>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void add(brick brick)
    {


finditt.addPoint(1);
        if (_Bricks.Count > 10)
        {
            _Bricks[0].Sleep();
            _Bricks.Remove(_Bricks[0]);
            
            if (!_Bricks.Contains(brick))
            {
                _Bricks.Add(brick);     
            }  
        }
        else
        {
            if (!_Bricks.Contains(brick))
            {
                _Bricks.Add(brick);     
            }  
            
        }


        
       
    }


    public void remove(brick brick)
    {


        _Bricks.Remove(brick);

    }
}
