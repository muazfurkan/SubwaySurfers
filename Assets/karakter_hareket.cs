using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter_hareket : MonoBehaviour
{
    bool sag = true;
    bool ortada_mi = true;
    bool sagda_mi = false;
    bool solda_mi = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hareket_et();
    }

    void hareket_et()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z+1.0f), Time.deltaTime * 3.0f);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sag = true;            
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sag = false;
        }

        if (sag)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(-22.33f, transform.position.y, transform.position.z), Time.deltaTime * 3.0f);


        }
        else
        {

            transform.position = Vector3.Lerp(transform.position, new Vector3(-24.90f, transform.position.y, transform.position.z), Time.deltaTime * 3.0f);
        }
    }
}
