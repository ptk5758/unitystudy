using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{
    public string[] weathers = { "¸¼À½", "Èå¸²", "ºñ", "º­¶ô"}; // 1 2 3 4 X 0 1 2 3
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
        // List => ³ªÁß¿¡ ÇÒ°Í
        // Array => ¹è¿­
        //   º¯¼ö¸¦ ¸ð¾ÆµÐ ¼­¶ø

        /*menu_arr[0] = "Â¥Àå¸é";
        menu_arr[1] = "Â«»Í";
        menu_arr[2] = "ººÀ½¹ä";

        Debug.Log(menus[1]);
        Debug.Log(menu_arr[2]);*/
    }
}
