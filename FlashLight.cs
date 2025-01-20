using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public GameObject spotLight;

    public bool isFlashLight = false; // 현재 라이트의 상태

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            // true -> false / false -> true
            isFlashLight = !isFlashLight; // 현재 상태의 반대가 된다는 의미
            spotLight.SetActive(isFlashLight);
        }
    }

    //spotLight.SetActive(false); // 존재 On
    //spotLight.SetActive(false); // 존재 Off

}
