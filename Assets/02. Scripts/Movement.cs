using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float h = 0f;
    private float v = 0f;
    public float rotSpeed = 30f;
    public float jumpPower = 10f; // ���� �Ŀ�
    public Transform target;
    public bool isGround = false;

    public Animator anim; // Animator Ÿ���� anim ���� ����
    
    private void Start()
    {
        
    }
    
    void Update()
    {
        Move(); // Move �Լ� ȣ��(����)
        Jump(); // Jump �Լ� ȣ��(����)
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true) // �����̽��ٸ� ������ ��
        {
            // �ڱ� �ڽ��� Rigidbody����ϴ� Component ���� / AddForce�� ���� ����(�������� jumpPower��ŭ ���� ���Ѵ�.)
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }

    private void Move() // ĳ���� �̵� ���� ���
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0f, v).normalized;

        transform.position += dir * Time.deltaTime * moveSpeed;

        if (h == 0 && v == 0) // �ƹ��� Ű�� ������ X
        {
            // �ȴ� �ִϸ��̼� ���� X
            anim.SetBool("isWalk", false);
        }
        else // �̵�Ű �� � Ű�� ������ ���
        {
            // �ȴ� �ִϸ��̼� ���� O
            anim.SetBool("isWalk", true);
        }

        if (h != 0 || v != 0)
        {
            Vector3 targetPos = transform.position + dir;
            transform.LookAt(targetPos);
        }
    }
}