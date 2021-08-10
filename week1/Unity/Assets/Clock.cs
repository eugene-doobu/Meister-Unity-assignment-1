using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
	// SerializeField로 인스펙터에서 값이나 참조 대상을 지정할 수 있음
	[SerializeField] Transform hoursPivot = default, minutesPivot, secondsPivot;

	// const는 변하지 않는 상수값을 지정할때 사용
	const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

	void Update()
	{
		DigitalClock();
	}

	void DigitalClock()
	{
		// 현재 장비의 시간 가져오기
		var time = DateTime.Now;

		// 유니티에서 회전은 Quaternion으로 표현
		// 우리에게 익숙한 각도로 나타내기 위해서는 Quaternion.Euler를 이용
		hoursPivot.localRotation =
			Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
		minutesPivot.localRotation =
			Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
		secondsPivot.localRotation =
			Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
	}
}
