using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentStudy : MonoBehaviour
{
    public Transform destination; //������ ������Ʈ

    void Start()
    {
        transform.position = destination.position; 
    }
}
