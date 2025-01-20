using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public GameObject spotLight;

    public bool isFlashLight = false; // ���� ����Ʈ�� ����

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            // true -> false / false -> true
            isFlashLight = !isFlashLight; // ���� ������ �ݴ밡 �ȴٴ� �ǹ�
            spotLight.SetActive(isFlashLight);
        }
    }

    //spotLight.SetActive(false); // ���� On
    //spotLight.SetActive(false); // ���� Off

}
