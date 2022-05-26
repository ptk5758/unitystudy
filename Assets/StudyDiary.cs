using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyDiary : MonoBehaviour
{
    public string[,] diary = new string[7,8];
    public int today_tow; // ��������� ���� ����
    public int today_time; // ���� ���ø� ���� ���� 

    void Start()
    {
        diary[0, 0] = "����"; //�Ͽ��Ͽ� 1���� ������ �������� �ʱ�ȭ �ϴ� �����ڵ�
        for (int i=0; i<7; i++) // i = ���� ����
        {
            for (int j=0; j<8; j++) // j = j ���� ����
            {
                //56 �� �ݺ��ϴ� ���� for �ϼ�
                diary[i, j] = "����";
            }
        }

        //diary[2, 0] = "����"; == SetTimeChart(2, 0, "����")
        SetTimeChart(2, 0, "����");
        SetTimeChart(2, 1, "����");
        SetTimeChart(2, 2, "����");

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
