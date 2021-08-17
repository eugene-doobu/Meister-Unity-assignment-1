using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUI : MonoBehaviour
{
    Text text;
    float time = 0f;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        // �������̶�� �÷��̽ð� ����
        if (!GameManager.instance.IsWin)
        {
            time += Time.deltaTime;
        }

        // ���ӸŴ������� Score ��������
        int score = GameManager.instance.Score;

        // Format�Լ��� �̿��Ͽ� ����ϱ�
        text.text = string.Format("Score: {0}\nTime: {1:0.00}", score, time);
    }
}
