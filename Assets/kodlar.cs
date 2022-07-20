using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kodlar : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform yol_1;
    public Transform yol_2;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTriggerEnter(Collider other)
    {

        if(other.gameObject.name == "duvar_2")
        {
            yol_1.position = new Vector3(yol_2.position.x, yol_2.position.y, yol_2.position.z + 18.94f);
            print("temas var");
        }

        if(other.gameObject.name == "duvar_1")
        {
            yol_2.position = new Vector3(yol_1.position.x, yol_1.position.y, yol_1.position.z + 18.94f);

        }
    }
}
