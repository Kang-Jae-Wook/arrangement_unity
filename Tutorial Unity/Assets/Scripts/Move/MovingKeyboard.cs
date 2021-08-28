using System.Collections;
using UnityEngine;

//  클래스를 생성하는 단축키 ?
//  Ctrl + Shift + A

//  키보드로 객체를 이동하는 컴포넌트
class MovingKeyboard : MonoBehaviour
{
    //  Update?
    //  지속적으로 호출된다
    //  Start 는 시작할 떄 한 번, Update 는 계속 호출됨!
    /*
    void Start()
    {
        int MaxHp = 10;
        int CurrentHp = 5;
        int Position = 10;  // 회복량 이라고 할 때
        //  실습 1.
        //  플레이어 (MaxHp) 가 포션을 먹었을 떄 CurrentHP 를 회복시키자!
        //  1. CurrentHp 는 Max Hp 보다 클 수 없 다

        int recoverHp = CurrentHp + Position;   //  포션을 먹은 다음
        if (recoverHp > MaxHp)
            recoverHp = MaxHp;

        CurrentHp = recoverHp;                  //  먹은 값을 현재 hp 에 대입
        Debug.Log(CurrentHp);                   //  출력



    }*/
    /*

 void Update()
 {
     // 키보드 또는 마우스 입력을 받고싶을 때는
     // Input 클래스를 사용하여야 한다
     // Input.GetKey()
     // Input.GetKeyDown()
     // Input.GetKeyUp()

     if (Input.GetKey(KeyCode.W))
     {
         // transform ? 위치, 회전, 크기 요소를 가지고 있는 컴포넌트
         //  행렬을 담당하는 컴포넌트 (3D 기준 4x4 matrix)
         //transform.position = new Vector3(
         //    transform.position.x + 0.1f,
         //    transform.position.y);

         transform.Translate(0.1f,0,0);
     }
}*/

    public Rigidbody rgd;
    public float Speed = 0;

    void Update()
    {
        float frameSpeed = Speed * Time.deltaTime;
        //  Time.deltaTime ?  매 프레임 타임
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(frameSpeed, 0, 0);
            //Vector3 position = transform.position;
            //rgd.MovePosition(new Vector3(position.x + 0.1f, position.y, position.z));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-frameSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, frameSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, -frameSpeed);
        }


    }


    //  물리연산업데이트
    void FixedUpdate()
    {
//        float frameSpeed = Speed * Time.deltaTime;
//        //  Time.deltaTime ?  매 프레임 타임
//        if (Input.GetKey(KeyCode.W))
//        {
//            transform.Translate(frameSpeed, 0, 0);
//            //Vector3 position = transform.position;
//            //rgd.MovePosition(new Vector3(position.x + 0.1f, position.y, position.z));
//        }
//
    }
}
    
