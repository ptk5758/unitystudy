using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{
    void Start()
    {
        // List => ���߿� �Ұ�
        // Array => �迭
        //   ������ ��Ƶ� ����

        string[] menus = { "�����", "��ġ�", "��������", "�η�ġ��" }; // 1 2 3 4 X 0 1 2 3
        string[] menu_arr = new string[4];
        menu_arr[0] = "¥���";
        menu_arr[1] = "«��";
        menu_arr[2] = "������";
        menu_arr[3] = "���";


        Debug.Log(menus[1]);
        Debug.Log(menu_arr[2]);
    }
    void Update()
    {
        
    }
}
