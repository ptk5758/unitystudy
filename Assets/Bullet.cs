using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public bool isMouseClick;    
    public Transform point1;
    public Transform point2;
    public Transform point3;
    public Transform point4;
    public Transform target;
    public int point; // �ش� �������� ���ؼ� target ������ point ������ ����


    void Update()
    {

        // ��ǥ�������� ������ �Լ��� X
        // Vector3.MoveTowards(������ġ Vector3, ��ǥ��ġ Vector3, �ӵ� float)  ��ǥ���������� ������ �ִ� �Լ� 
        // ����ġ�� 0,0,0 ��ǥ��ġ�� 1,1,1 �ӵ��� 0.5f 
        //Vector3 target = new Vector3(-1, 0.65f, 3.81f); 

        if (point == 1)
        {
            target = point1;
        }
        else if (point == 2)
        {
            target = point2;
        }
        else if (point == 3)
        {
            target = point3;
        }
        else if (point == 4)
        {
            target = point4;
        }

        // && => AND ������ ���� �Ŷ� �����ʰ� �Ѵ� ���ϰ�� true return 
        // ���찡 Ŭ���ϸ鼭 ~ target Null �̾ƴҶ�
        // null �̶� ������Ʈ ���� ���
        if (isMouseClick && target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, 0.005f);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("�ʴ� ���콺 ��Ŭ���� �ߴ�.");
            isMouseClick = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("�ʴ� ���콺 ��Ŭ���� ����.");
            isMouseClick = false;
        }

    }

    void Start()
    {

    }
}