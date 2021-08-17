using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRot : MonoBehaviour
{
    public float speed = 5f;
    Transform tr;

    private void Awake()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        // 1�ʴ� speed����(deg)��ŭ ȸ��
        tr.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
