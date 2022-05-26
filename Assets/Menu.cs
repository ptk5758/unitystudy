using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // 1. 배열안에 선택지를 나열 
    // 2. 키보드 Input 을 이요해서 선택지 선택
    // 3. Space? 무튼 선택해서 Debug.Log

    // 4. 현재 커서상태에서 space 바를 누르면 그메뉴를 출력하는 함수 만들기
    public string[] menu_arr;
    public int cursur;

    // cursur 라는 변수를 본인들 원하는 키보드 입력 함수를 통해서 바꾸기 ex) Tap키 스페이스바키 1,23,4, ,a,b,c,d    
    void Update()
    {
        // 배열은 0부터 시작        
        //Debug.Log(menu_arr[cursur]);
        ChangeCursur();
        PrintCursurMenu();
        //Debug.Log(menu_arr.Length); // 파이썬 len(배열)
        //array.Length => 배열의 길이를 반환
        CodeTest();
    }

    void ChangeCursur() //키보드 입력을 감지하는 함수
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cursur = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cursur = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            cursur = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            cursur = 3;
        }
    }

    void PrintCursurMenu() //현재 커서가 가르치고 있는 메뉴를 출력하는 함수
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(menu_arr[cursur]);
        }
    }

    void CodeTest() //// s 게임 Start 함수를 호출하는느낌
    {
        if (Input.GetKeyDown(KeyCode.S))
        {            
            for (int index = 0; index < 4; index++) 
            {                
                Debug.Log(menu_arr[index]);
            }
        }
    }


}
