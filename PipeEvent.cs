using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeEvent : MonoBehaviour
{
    public SoundManager soundManager;
    public GameObject endUI;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            soundManager.OnCollisionSound();
            endUI.SetActive(true); // ���� UI�� ������ ���

            Debug.Log("Game Over");
        }
    }
}
