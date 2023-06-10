using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudDestroyer : MonoBehaviour
{
    public float destroyDelay = 3f; // ������������ ���� �ð�

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cloud"))
        {
            Invoke("DestroyCloud", destroyDelay); // ���� �ð� �Ŀ� DestroyCloud() �޼��� ȣ��
        }
    }

    private void DestroyCloud()
    {
        Destroy(gameObject); // ���� ��ũ��Ʈ�� ����� ���� ������Ʈ�� �ı�
    }
}
