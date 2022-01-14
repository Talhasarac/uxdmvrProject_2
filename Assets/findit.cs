using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class findit : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform obj;
    public float point;
    public Transform looktothisguy;
    public float maxpoint;
    public AudioSource music;
    public Slider _Slider;

    public AudioSource victorySound;
    public Vector3 Vector3;
    bool ended;
    
    void Start()
    {
        
    }


    public void addPoint(int pointToAdd)
    {


        if(ended)
        return;
        point += pointToAdd;
        
        

        if(point >= maxpoint){
         
         Invoke("victory",2f);
transform.GetChild(0).gameObject.SetActive(false);
transform.GetChild(1).gameObject.SetActive(false);
transform.GetChild(2).gameObject.SetActive(true);

ended = true;
        }
        _Slider.value = point / maxpoint;
    }
    // Update is called once per frame
    void Update()
    {


if(ended)
   music.volume = Mathf.MoveTowards(music.volume,0,Time.deltaTime/2);

        transform.position = obj.position + Vector3;
transform.LookAt(looktothisguy.position);        
    }


    void victory(){

victorySound.Play();
    }
}
