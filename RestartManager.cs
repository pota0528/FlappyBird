using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour
{
    public string SceneName;  //�ҷ��þ�
    public void Load()
    {
        SceneManager.LoadScene(SceneName);
    }
}
