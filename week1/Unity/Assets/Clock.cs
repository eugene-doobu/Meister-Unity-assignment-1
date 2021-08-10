using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
	// SerializeField�� �ν����Ϳ��� ���̳� ���� ����� ������ �� ����
	[SerializeField] Transform hoursPivot = default, minutesPivot, secondsPivot;

	// const�� ������ �ʴ� ������� �����Ҷ� ���
	const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

	void Update()
	{
		DigitalClock();
	}

	void DigitalClock()
	{
		// ���� ����� �ð� ��������
		var time = DateTime.Now;

		// ����Ƽ���� ȸ���� Quaternion���� ǥ��
		// �츮���� �ͼ��� ������ ��Ÿ���� ���ؼ��� Quaternion.Euler�� �̿�
		hoursPivot.localRotation =
			Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
		minutesPivot.localRotation =
			Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
		secondsPivot.localRotation =
			Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
	}
}
