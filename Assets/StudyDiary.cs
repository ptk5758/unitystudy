using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyDiary : MonoBehaviour
{
    public string[,] diary = new string[7,8];
    public int today_tow; // 현재요일을 담은 변수
    public int today_time; // 현재 교시를 담은 변수 

    void Start()
    {
        diary[0, 0] = "토익"; //일요일에 1교시 수업을 토익으로 초기화 하는 예시코드
        for (int i=0; i<7; i++) // i = 요일 변수
        {
            for (int j=0; j<8; j++) // j = j 교시 변수
            {
                //56 번 반복하는 이중 for 완성
                diary[i, j] = "공강";
            }
        }

        //diary[2, 0] = "토익"; == SetTimeChart(2, 0, "토익")
        SetTimeChart(2, 0, "토익");
        SetTimeChart(2, 1, "토익");
        SetTimeChart(2, 2, "토익");

        //Debug.Log(diary[3,1]);


    }

    void SetTodayTow()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            today_tow = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            today_tow = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            today_tow = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            today_tow = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            today_tow = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            today_tow = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            today_tow = 6;
        }
    }

    void SetTodayTime()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            today_time++;
            if (today_time == 8)
            {
                today_time = 0;
            }
        }
    }

    void PrintNowSch()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(diary[today_tow, today_time]);
        }
        
    }

    void Update()
    {
        SetTodayTow();
        SetTodayTime();
        PrintNowSch();
    }

    void SetTimeChart(int dow, int time, string content)
    {
        diary[dow, time] = content;
    }
}
