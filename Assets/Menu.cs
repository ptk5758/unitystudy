using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // 1. �迭�ȿ� �������� ���� 
    // 2. Ű���� Input �� �̿��ؼ� ������ ����
    // 3. Space? ��ư �����ؼ� Debug.Log

    // 4. ���� Ŀ�����¿��� space �ٸ� ������ �׸޴��� ����ϴ� �Լ� �����
    public string[] menu_arr;
    public int cursur;

    // cursur ��� ������ ���ε� ���ϴ� Ű���� �Է� �Լ��� ���ؼ� �ٲٱ� ex) TapŰ �����̽���Ű 1,23,4, ,a,b,c,d    
    void Update()
    {
        // �迭�� 0���� ����        
        //Debug.Log(menu_arr[cursur]);
        ChangeCursur();
        PrintCursurMenu();
        //Debug.Log(menu_arr.Length); // ���̽� len(�迭)
        //array.Length => �迭�� ���̸� ��ȯ
        CodeTest();
    }

    void ChangeCursur() //Ű���� �Է��� �����ϴ� �Լ�
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

    void PrintCursurMenu() //���� Ŀ���� ����ġ�� �ִ� �޴��� ����ϴ� �Լ�
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(menu_arr[cursur]);
        }
    }

    void CodeTest() //// s ���� Start �Լ��� ȣ���ϴ´���
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
