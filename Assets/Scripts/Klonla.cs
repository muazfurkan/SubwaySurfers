using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klonla : MonoBehaviour
{
    public GameObject altin;
    public GameObject miknatis;

    public Transform PlayerController;

    float silinme_zamani = 5.0f;

    float sag_kordinat = -21.18645f;
    float orta_kordinat = -23.58645f;
    float sol_kordinat = -25.68645f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("nesne_klonla",0,0.5f);
    }

    void nesne_klonla(){
        int rastsayi = Random.Range(0,100);

        if(rastsayi>0 && rastsayi<80){
            klon(altin, 0.979f);
        }
        if(rastsayi>95 && rastsayi<100){
            if(PlayerController.gameObject.GetComponent<PlayerController>().miknatis_alindi == false){
                klon(miknatis, 0.979f);
            }
            
        }
    }  

        


    void klon(GameObject nesne, float Y_kordinat){
        GameObject yeni_klon= Instantiate(nesne);

        int rastsayi =  Random.Range(0,100);

        if(rastsayi<30)
        {
            yeni_klon.transform.position =new Vector3(sag_kordinat, Y_kordinat, PlayerController.position.z + 8.0f);
        }
        else if(30 < rastsayi && rastsayi < 60)
        {
            yeni_klon.transform.position =new Vector3(orta_kordinat, Y_kordinat, PlayerController.position.z + 8.0f);

        }
        else if(60 < rastsayi && rastsayi < 100)
        {
            yeni_klon.transform.position =new Vector3(sol_kordinat, Y_kordinat, PlayerController.position.z + 8.0f);

        }
        // Destroy(yeni_klon,silinme_zamani);
    }

}
