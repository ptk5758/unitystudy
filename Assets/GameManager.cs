using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int index;
    public string[] books; //6�� ������ ���� å�� 6�� ������
    void Start()
    {
        // �ݺ�����
        // 1. while
        // 2. for
        TestWhile();
    }

    void TestWhile()
    {
        // while �� while (����) { ���� ��ų } // ���ǹ��� true �̸� �ݺ��ؼ� �ٱ�ȣ�� ���� ȣ�� [if �ݺ�����]        
        // books.Length => �迭�� ���̸� ������
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
