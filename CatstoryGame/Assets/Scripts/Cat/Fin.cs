using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour
{
    private bool playerCollided = false; // �÷��̾�� �浹�ߴ��� ���θ� �����ϴ� ����

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerCollided = true; // �÷��̾�� �浹������ ǥ��
        }
    }

    private void Update()
    {
        if (playerCollided && Input.GetKeyDown(KeyCode.Space)) // �÷��̾�� �浹�� �� �����̽��ٸ� ������ ��
        {
            SceneManager.LoadScene("Text_003_Scene"); // ���� ������ �̵�
        }
    }
}
