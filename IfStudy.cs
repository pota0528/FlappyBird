using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStudy : MonoBehaviour
{
    public int currentLevel = 1; // ���� ���� ���� = 1
    void Start()
    {
        if (currentLevel < 10) // ���� ������ 10���� ������, �ʺ��� ����� ��� ����
        {
            Debug.Log("�ʺ��� ����� O");
        }
        else if (currentLevel > 10) // ���� ������ 10���� ũ��, �ʺ��� ����� ��� �Ұ���
        {
            Debug.Log("�ʺ��� ����� X");
        }
        else // currentLevel == 10�� ���
        {
            Debug.Log("������ 10�̹Ƿ�, �ʺ��� ����� O");
        }
    }

    void Update()
    {
        
    }
}
