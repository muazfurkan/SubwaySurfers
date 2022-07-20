using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vagon_move : MonoBehaviour
{
   float hiz =5;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, hiz * Time.deltaTime);
    }
}
