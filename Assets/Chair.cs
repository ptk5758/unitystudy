using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    
    void Start() // 오브잭트 생성되고 한번만 호출됨
    {
        string name = "초록의자"; // string = > "문자열" 을 표기하기 위한 데이터 타입
        int price = 5000; // int => 숫자를 표시하기 위한 데이터 타입 
        float weight = 8.5f; // float => 소수점(실수) 를 표기하기 위한 데이터 타입
        bool isBroken = false; // bool => 참 거짓 을 표기하기위한 데이터 타입
    }

    
    void Update() //오브잭트가 살아있는동안 계속 호출됨
    {
        
    }
}
