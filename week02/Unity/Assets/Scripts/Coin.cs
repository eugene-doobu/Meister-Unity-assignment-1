using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // �����̶� ��ü �浹�� ������ 1 �ø��� ���� ����
        GameManager.instance.Score += 1;
        Destroy(gameObject);
    }
}
