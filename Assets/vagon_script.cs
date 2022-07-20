using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class vagon_script : MonoBehaviour

    
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
            SceneManager.LoadScene(0);
        }
        
    }
}
