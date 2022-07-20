using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel_olustur : MonoBehaviour
{
    public GameObject vagon;

    public Transform karakter;

    float engel_kaldir = 5.0f;

    float sag_taraf = 0.2f;
    float sol_taraf = -0.25f;
    float orta_taraf = -0.03f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("engel_clone", 0, 0.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void nesne_olusturma()
    {

        int sayi = Random.Range(0, 100);

        if(sayi <= 80)
        {
            engel_klonu(vagon, 0.0f);
        }
    }

    void engel_klonu(GameObject nesne, float koordinat)
    {
        GameObject yeni_nesne = Instantiate(nesne);

        int ne_taraf = Random.Range(0, 12);

        if(ne_taraf < 4)
        {
            yeni_nesne.transform.position = new Vector3(sag_taraf, koordinat, karakter.position.z + 15.0f);
        }

        else if(ne_taraf >= 4 && ne_taraf < 8)
        {
            yeni_nesne.transform.position = new Vector3(orta_taraf, koordinat, karakter.position.z + 15.0f);
        }
        else
        {
            yeni_nesne.transform.position = new Vector3(sag_taraf, koordinat, karakter.position.z + 15.0f);
        }
    }
}
