using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{
    public string[] weathers = { "����", "�帲", "��", "����"}; // 1 2 3 4 X 0 1 2 3
    //public string[] menu_arr = new string[4];
    public int x;

    void PrintWeather()
    {        
        Debug.Log(GetWeather());
    }

    string GetWeather()
    {        
        return weathers[x];
    }

    void Update()
    {
        PrintWeather();
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
