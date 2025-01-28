using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEvent : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            // ������� ����� �����? -> Player Tag�� ���� ������Ʈ
            GameObject characterObj = collision.gameObject;

            // ĳ���� ������Ʈ�� Movement ��ũ��Ʈ(������Ʈ)�� �����ؼ� isGround�� �ٲ���Ѵ�.
            characterObj.GetComponent<Movement>().isGround = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GameObject characterObj = collision.gameObject;

            characterObj.GetComponent<Movement>().isGround = false;
        }
    }
}
