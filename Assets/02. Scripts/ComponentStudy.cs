using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentStudy : MonoBehaviour
{
    public Transform destination; //목적지 오브젝트

    void Start()
    {
        transform.position = destination.position; 
    }
}
