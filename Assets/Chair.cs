using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public string name; // string = > "문자열" 을 표기하기 위한 데이터 타입
    public int price; // int => 숫자를 표시하기 위한 데이터 타입 
    public float weight; // float => 소수점(실수) 를 표기하기 위한 데이터 타입
    public bool isBroken; // bool => 참 거짓 을 표기하기위한 데이터 타입

    void Start() // 오브잭트 생성되고 한번만 호출됨
    {
        // 연산자 시작
        // + / * - % , < > , <= , >=

        // < , >= , && , || , == , != 특징 // 무조건 bool 의 값을 반환 => true , false

        //Debug.Log(price != 10000); // 유니티 에디터에서 설정 값에 따라서 true 아니면 false

        price += 500; 
        price -= 300;
        
    }

    void Update() //오브잭트가 살아있는동안 계속 호출됨
    {
        //유니티에서 제공하는 Input 함수 가있음

        //키보드 감지 함수        
        Debug.Log(Input.GetKeyDown(KeyCode.Space)); // => false 를 출력하다가 KeyCode.스페이스바 를 누른순간 true 가 출력


        //오브제트를 움직이기
        //Vector3 asdf = new Vector3(0,5,0); // new Vector(x좌표, y좌표, z자표); 
        Vector3 a = new Vector3(0, 0.008f, 0);
        if (Input.GetKey(KeyCode.Space)) 
        {
            //transform.position = asdf; //로 움직이기는 X 텔레포트 O
            // 의 방향으로 이동시키기
            // transform.Translate(백터값); => 오브잭트를 백터값의 방향으로 잡아땡기기
            transform.Translate(a);
        }
         

    }
}
