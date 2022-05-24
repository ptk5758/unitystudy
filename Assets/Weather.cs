using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{
    public string[] weathers = { "맑음", "흐림", "비", "벼락"}; // 1 2 3 4 X 0 1 2 3
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
        
        ChangeWeather(); //키보드 입력 감지 함수
        PrintWeather();  //현재 날씨를 출력하는 함수        
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
        // List => 나중에 할것
        // Array => 배열
        //   변수를 모아둔 서랍

        /*menu_arr[0] = "짜장면";
        menu_arr[1] = "짬뽕";
        menu_arr[2] = "볶음밥";

        Debug.Log(menus[1]);
        Debug.Log(menu_arr[2]);*/
    }
}
