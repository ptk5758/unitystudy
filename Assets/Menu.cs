using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // 1. 배열안에 선택지를 나열 
    // 2. 키보드 Input 을 이요해서 선택지 선택
    // 3. Space? 무튼 선택해서 Debug.Log
    public string[] menu_arr;
    public int cursur;

    // cursur 라는 변수를 본인들 원하는 키보드 입력 함수를 통해서 바꾸기 ex) Tap키 스페이스바키 1,23,4, ,a,b,c,d

    void Update()
    {
        // 배열은 0부터 시작
        Debug.Log(menu_arr[cursur]);
    }
}
