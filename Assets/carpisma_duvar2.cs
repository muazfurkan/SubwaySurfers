using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpisma_duvar2 : MonoBehaviour

    
{

    public Transform yol_1;
    public Transform yol_2;
    public Transform vagon_1;
    public Transform vagon_2;
    public Transform vagon_3;
    public Transform vagon_4;
    public Transform vagon_5;
    public Transform row_sol;
    public Transform row_sag;
    public Transform row_orta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider nesne)
    {
        if (nesne.gameObject.name == "karakter")
        {
            int Randomsayi = Random.Range(-3, 3);
            yol_1.position = new Vector3(yol_2.position.x, yol_2.position.y, yol_2.position.z + 18.94f);
            vagon_1.position = new Vector3(row_sag.position.x, vagon_1.position.y, vagon_1.position.z + Randomsayi);
            vagon_2.position = new Vector3(row_sag.position.x, vagon_2.position.y, vagon_2.position.z + Randomsayi);
            vagon_3.position = new Vector3(row_orta.position.x, vagon_3.position.y, vagon_3.position.z+ Randomsayi);
            vagon_4.position = new Vector3(row_sol.position.x, vagon_4.position.y, vagon_4.position.z+ Randomsayi);
            vagon_5.position = new Vector3(row_sol.position.x, vagon_5.position.y, vagon_5.position.z+ Randomsayi);
        }
        
    }
}
