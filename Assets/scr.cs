using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    Transform karakter_takip;
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, karakter_takip.position, Time.deltaTime * 3.0f);
    }
}
