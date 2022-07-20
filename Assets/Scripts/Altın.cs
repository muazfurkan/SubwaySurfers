using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altın : MonoBehaviour
{
    PlayerController karakter;
    Transform temas_kup;

    float mesafe;
    // Start is called before the first frame update
    void Start()
    {
        karakter = GameObject.Find("karakter").GetComponent<PlayerController>();
        temas_kup = GameObject.Find("karakter/temas_kup").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(karakter.miknatis_alindi == true)
        {
            mesafe = Vector3.Distance(transform.position, temas_kup.position);
            if(mesafe <= 10){
                transform.position =Vector3.MoveTowards(transform.position, temas_kup.position,  Time.deltaTime * 10.0f);
            }
        }
        
    }
}
