using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int index;
    public string[] books; //6개 에디터 기준 책이 6권 들어가있음
    void Start()
    {
        // 반복문은
        // 1. while
        // 2. for
        TestWhile();
    }

    void TestWhile()
    {
        // while 문 while (조건) { 실행 시킬 } // 조건문이 true 이면 반복해서 줄광호의 내용 호출 [if 반복버전]        
        // books.Length => 배열의 길이를 리턴함
        //Debug.Log(books.Length);
        int index = 0;
        while (index < books.Length)
        {            
            Debug.Log(books[index]);
            index++;
        }
    }

    void TestFor()
    { 
    }
}
