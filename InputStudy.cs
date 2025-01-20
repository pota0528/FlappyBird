using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputStudy : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) // WŰ
        {
            Debug.Log("W");
        }

        if (Input.GetKeyDown(KeyCode.S)) // SŰ
        {
            Debug.Log("S");
        }

        if (Input.GetKeyDown(KeyCode.Space)) // �����̽�
        {
            Debug.Log("Space");
        }

        if (Input.GetKeyDown(KeyCode.Return)) // ����
        {
            Debug.Log("return");
        }

        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư ������ ����
        {
            Debug.Log("���콺 ���� ��ư�� ������ ����");
        }

        if (Input.GetMouseButton(0)) // ���콺 ���� ��ư ������ ����
        {
            Debug.Log("���콺 ���� ��ư ������ ��");
        }
    }
}
