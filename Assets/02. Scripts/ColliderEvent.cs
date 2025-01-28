using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEvent : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹 Enter");
    }

    public void OnCollisionStay(Collision collision)
    {
        Debug.Log("�浹 Stay");

    }

    public void OnCollisionExit(Collision collision)
    {
        Debug.Log("�浹 Exit");

    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("���� Enter");
    }

    public void OnTriggerStay(Collider other)
    {
        Debug.Log("���� Stay");

    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("���� Exit");

    }
}
