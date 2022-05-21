using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //함수란 기능(동작)을 수행하는 모듈

    //청소하는 행위를 알고리즘 표현하면 ?
    // 빗자루를 준비하고
    // 빗자루를 이용하여 바닥을쓸고
    // 빗자루를 재자리에 두는것 

    // 함수는 () 붙어있으면 99퍼센트는 함수이다

    void DoClean(string tool) //청소를 하는 함수
    {
        Debug.Log(tool + "를 준비");
        Debug.Log(tool + "를 이용하여 바닥을 쓸기");
        Debug.Log(tool + "를 원위치");
    }

    // void => return 없을때
    // int => int return 받음
    // float => float return 받음
    // string => string return 

    int someFunction()
    {
        int asdf = 6;
        return asdf;
    }


    void CryWeather()
    {
        Debug.Log("오늘 날씨는 흐림 입니다");
    }

    string GetWeather() // 교수님이 학생아 오늘 날씨가 어떻노? "학생 : 오늘 맑은데요"
    {
        //string weather = "맑음";
        string weather = "흐림";
        //string weather = "눈";

        return weather;
    }

    void Start()
    {
        //Debug.Log("아 청소를 좀 해볼까");
        //DoClean("빗자루");
        //Debug.Log(someFunction());

        string todayWeather = GetWeather();
        //Debug.Log(todayWeather);
        CryWeather();
    }

    int GetRandomNumber()
    {
        int value = Random.Range(0, 5); // 0 ~ 4 까지 랜덤 숫자를 리턴
        return value;
    }

    void Update()
    {
        int randomValue = GetRandomNumber();
        Debug.Log(randomValue);
    }

}
