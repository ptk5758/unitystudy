using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{
    void Start()
    {
        // List => 나중에 할것
        // Array => 배열
        //   변수를 모아둔 서랍

        string[] menus = { "된장찌개", "김치찌개", "제육볶음", "두루치기" }; // 1 2 3 4 X 0 1 2 3
        string[] menu_arr = new string[4];
        menu_arr[0] = "짜장면";
        menu_arr[1] = "짬뽕";
        menu_arr[2] = "볶음밥";
        menu_arr[3] = "울면";


        Debug.Log(menus[1]);
        Debug.Log(menu_arr[2]);
    }
    void Update()
    {
        
    }
}
