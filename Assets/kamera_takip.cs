using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera_takip : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject karakter;

    public Vector3 nesneler_farki;
    void Start()
    {
        nesneler_farki = transform.position - karakter.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = karakter.transform.position + nesneler_farki;
    }
}
