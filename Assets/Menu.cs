using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // 1. �迭�ȿ� �������� ���� 
    // 2. Ű���� Input �� �̿��ؼ� ������ ����
    // 3. Space? ��ư �����ؼ� Debug.Log
    public string[] menu_arr;
    public int cursur;

    // cursur ��� ������ ���ε� ���ϴ� Ű���� �Է� �Լ��� ���ؼ� �ٲٱ� ex) TapŰ �����̽���Ű 1,23,4, ,a,b,c,d

    void Update()
    {
        // �迭�� 0���� ����
        Debug.Log(menu_arr[cursur]);
    }
}
