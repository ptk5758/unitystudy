using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{
    public string[] weathers = { "����", "�帲", "��", "����"}; // 1 2 3 4 X 0 1 2 3
    public int todayWeather;

    void PrintWeather()
    {        
        Debug.Log(GetWeather());
    }

    string GetWeather()
    {        
        return weathers[todayWeather];
    }

    void Update()
    {
        
        ChangeWeather(); //Ű���� �Է� ���� �Լ�
        PrintWeather();  //���� ������ ����ϴ� �Լ�        
    }

    void ChangeWeather()
    {        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            todayWeather = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            todayWeather = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            todayWeather = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            todayWeather = 3;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            todayWeather++;
            if (todayWeather == weathers.Length)
            {
                todayWeather = 0;
            }            
        }
    }


    void Start()
    {
        // List => ���߿� �Ұ�
        // Array => �迭
        //   ������ ��Ƶ� ����

        /*menu_arr[0] = "¥���";
        menu_arr[1] = "«��";
        menu_arr[2] = "������";

        Debug.Log(menus[1]);
        Debug.Log(menu_arr[2]);*/
    }
}
