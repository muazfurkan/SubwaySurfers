using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraFollowPlayer : MonoBehaviour
{

    public GameObject karakter;
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - karakter.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = karakter.transform.position + offset;
    }
}
