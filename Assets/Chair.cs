using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public string name; // string = > "���ڿ�" �� ǥ���ϱ� ���� ������ Ÿ��
    public int price; // int => ���ڸ� ǥ���ϱ� ���� ������ Ÿ�� 
    public float weight; // float => �Ҽ���(�Ǽ�) �� ǥ���ϱ� ���� ������ Ÿ��
    public bool isBroken; // bool => �� ���� �� ǥ���ϱ����� ������ Ÿ��

    void Start() // ������Ʈ �����ǰ� �ѹ��� ȣ���
    {
        // ������ ����
        // + / * - % , < > , <= , >=

        // < , >= , && , || , == , != Ư¡ // ������ bool �� ���� ��ȯ => true , false

        //Debug.Log(price != 10000); // ����Ƽ �����Ϳ��� ���� ���� ���� true �ƴϸ� false

        price += 500; 
        price -= 300;
        
    }

    void Update() //������Ʈ�� ����ִµ��� ��� ȣ���
    {
        //����Ƽ���� �����ϴ� Input �Լ� ������

        //Ű���� ���� �Լ�        
        Debug.Log(Input.GetKeyDown(KeyCode.Space)); // => false �� ����ϴٰ� KeyCode.�����̽��� �� �������� true �� ���


        //������Ʈ�� �����̱�
        //Vector3 asdf = new Vector3(0,5,0); // new Vector(x��ǥ, y��ǥ, z��ǥ); 
        Vector3 a = new Vector3(0, 0.008f, 0);
        if (Input.GetKey(KeyCode.Space)) 
        {
            //transform.position = asdf; //�� �����̱�� X �ڷ���Ʈ O
            // �� �������� �̵���Ű��
            // transform.Translate(���Ͱ�); => ������Ʈ�� ���Ͱ��� �������� ��ƶ����
            transform.Translate(a);
        }
         

    }
}
