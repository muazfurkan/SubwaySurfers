using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public Animator animasyon;
    public TMPro.TextMeshProUGUI puan_txt;
    public TMPro.TextMeshProUGUI toplanan_altin_txt;
    public Rigidbody rigi;

    int puan = 0;
    int toplanan_altin = 0;

    public bool miknatis_alindi =false;
     
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "altin"){

                Destroy(other.gameObject);
            
                toplanan_altin++;
                puan +=10;
                puan_txt.text = puan.ToString("00000");
                toplanan_altin_txt.text = toplanan_altin.ToString();

            }

        if(other.gameObject.tag == "engel"){
            SceneManager.LoadScene(1);
            Time.timeScale = 0.0f;
        }

        if(other.gameObject.tag == "miknatis"){
            GameObject[] tum_miknatislar = GameObject.FindGameObjectsWithTag("miknatis");

            foreach (GameObject miknatis in tum_miknatislar)
            {
                Destroy(miknatis);
            }
            miknatis_alindi = true;
            Invoke("miknatisi_resetle",10.0f);

        }
    }
    public float movementSpeed= 0.015f;
    public void Update()
    {
        hareket();
    }
    void hareket(){
        transform.Translate(0,0,2 * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            animasyon.SetBool("Runtojumpspring",true);
            rigi.velocity = Vector3.up * 300.0f * Time.deltaTime;
            Invoke("ziplama_iptal",0.05f);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            //sola hareket
            Vector3 oldPosition = transform.position;
            oldPosition.x += 2.2f;
            transform.position = oldPosition;
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //sola hareket
            Vector3 oldPosition = transform.position;
            oldPosition.x -= 2.2f;
            transform.position = oldPosition;
        }
    
    }
    void miknatisi_resetle()
    {
        miknatis_alindi = false;
    }
// -25.68645
// -23.58645
// -21.18645 -23.58645 -21.18645
// 2.1
}
