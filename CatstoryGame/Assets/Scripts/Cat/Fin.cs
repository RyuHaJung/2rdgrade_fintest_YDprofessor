using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour
{
    private bool playerCollided = false; // 플레이어와 충돌했는지 여부를 저장하는 변수

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerCollided = true; // 플레이어와 충돌했음을 표시
        }
    }

    private void Update()
    {
        if (playerCollided && Input.GetKeyDown(KeyCode.Space)) // 플레이어와 충돌한 후 스페이스바를 눌렀을 때
        {
            SceneManager.LoadScene("Text_003_Scene"); // 다음 씬으로 이동
        }
    }
}
