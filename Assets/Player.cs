using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //�Լ��� ���(����)�� �����ϴ� ���

    //û���ϴ� ������ �˰��� ǥ���ϸ� ?
    // ���ڷ縦 �غ��ϰ�
    // ���ڷ縦 �̿��Ͽ� �ٴ�������
    // ���ڷ縦 ���ڸ��� �δ°� 

    // �Լ��� () �پ������� 99�ۼ�Ʈ�� �Լ��̴�

    void DoClean(string tool) //û�Ҹ� �ϴ� �Լ�
    {
        Debug.Log(tool + "�� �غ�");
        Debug.Log(tool + "�� �̿��Ͽ� �ٴ��� ����");
        Debug.Log(tool + "�� ����ġ");
    }

    // void => return ������
    // int => int return ����
    // float => float return ����
    // string => string return 

    int someFunction()
    {
        int asdf = 6;
        return asdf;
    }


    void CryWeather()
    {
        Debug.Log("���� ������ �帲 �Դϴ�");
    }

    string GetWeather() // �������� �л��� ���� ������ ���? "�л� : ���� ��������"
    {
        //string weather = "����";
        string weather = "�帲";
        //string weather = "��";

        return weather;
    }

    void Start()
    {
        //Debug.Log("�� û�Ҹ� �� �غ���");
        //DoClean("���ڷ�");
        //Debug.Log(someFunction());

        string todayWeather = GetWeather();
        //Debug.Log(todayWeather);
        CryWeather();
    }

    int GetRandomNumber()
    {
        int value = Random.Range(0, 5); // 0 ~ 4 ���� ���� ���ڸ� ����
        return value;
    }

    void Update()
    {
        int randomValue = GetRandomNumber();
        Debug.Log(randomValue);
    }

}
