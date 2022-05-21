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
    public Transform[] tetst;
    public int point; // 해당 변수값을 통해서 target 변수를 point 변수로 대입


    void Update()
    {

        // 목표지점으로 보내는 함수가 X
        // Vector3.MoveTowards(현재위치 Vector3, 목표위치 Vector3, 속도 float)  목표지점으로의 방향을 주는 함수 
        // 내위치가 0,0,0 목표위치가 1,1,1 속도는 0.5f 
        //Vector3 target = new Vector3(-1, 0.65f, 3.81f); 

        SetTarget();
        KeyListener();

        // && => AND 연산자 왼쪽 거랑 오른쪽거 둘다 참일경우 true return 
        // 마우가 클릭하면서 ~ target Null 이아닐때
        // null 이란 오브잭트 없을 경우
        if (isMouseClick && target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, 0.005f);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("너는 마우스 좌클릭을 했다.");
            isMouseClick = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("너는 마우스 좌클릭을 땟다.");
            isMouseClick = false;
        }

    }

    void KeyListener()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            point = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            point = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            point = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            point = 4;
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            point++;
            if (point == 5)
            {
                point = 1;
            }
        }

    }


    void SetTarget()
    {
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
    }
}
