using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudDestroyer : MonoBehaviour
{
    public float destroyDelay = 3f; // 사라지기까지의 지연 시간

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cloud"))
        {
            Invoke("DestroyCloud", destroyDelay); // 일정 시간 후에 DestroyCloud() 메서드 호출
        }
    }

    private void DestroyCloud()
    {
        Destroy(gameObject); // 현재 스크립트가 연결된 구름 오브젝트를 파괴
    }
}
