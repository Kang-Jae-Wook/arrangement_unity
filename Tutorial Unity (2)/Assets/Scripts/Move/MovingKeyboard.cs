using System.Collections;
using UnityEngine;

//  클래스를 생성하는 단축키 ?
//  Ctrl + Shift + A

//  키보드로 객체를 이동하는 컴포넌트
public class MovingKeyboard : MonoBehaviour
{
    //  Update ?
    //  지속적으로 호출된다
    //  Start 는 시작할 때 한 번, Update 는 계속 호출됨!

    /*
    void Start()
    {
        //  조건문 ?
        //  if 문
        //  if (조건) { 조건이 맞으면 실행될 내용 }
        //  또는
        //  if (), else if (), else
        //  if (조건이 맞으면) { 실행 }
        //  else if (위 조건이 안맞고, 이 안에 있는 조건이 맞으면) { 실행 }
        //  else 위에 있는 조건이 하나도 맞지 않으면 { 실행 }
        //  1. if, else if 소괄호 안에는 반드시 조건이 있어야 한다.
        //  2. else 는 조건이 없어야 한다
        //  3. else if 는 여러번 사용할 수 있다
        //  ex ) int A = 10, B = 5; 
        //       if (A == 5) { 실행 }
        //       else if (A != 5) { 실행 }
        //       else if (B != 5) { 실행 } ... 

        int MaxHp = 10;
        int CurrentHp = 5;
        int Position = 10;  //  회복량 이라고 할 때
        //  실습 1.
        //  플레이어 (MaxHp) 가 포션을 먹었을 때 CurrentHP 를 회복시키자!
        //  밑에 있는 잘못된 코드 부분을 수정해보세요
        //  1. CurrentHp 는 MaxHp 보다 클 수 없다
        //  2. CurrentHp 는 MaxHp 보다 같거나 작을 수 있다

        int recoverHp = CurrentHp + Position;   //  포션을 먹은 다음 (변수 = 5 + 10)
        CurrentHp = recoverHp > MaxHp ? MaxHp : recoverHp;  //  삼항 조건문, 연산자
        if (recoverHp > MaxHp)
        {
            CurrentHp = MaxHp;
        }
        CurrentHp = recoverHp;                  //  먹은 값을 현재 hp 에 대입
        if (CurrentHp > MaxHp)
        {
            CurrentHp = MaxHp;
        }
        Debug.Log(CurrentHp);                  //  출력
    }
    */
    /*
    void Update()
    {
        //  키보드 또는 마우스 입력을 받고싶을 때는
        //  Input 클래스를 사용하여야 한다
        //  Input.GetKey()          눌렀을 때 계속 참 (true)
        //  Input.GetKeyDown()      눌렀을 때 한 번만 참
        //  Input.GetKeyUp()        눌렀다 뗏을 때 한 번만 참

        //  transform ? 위치, 회전, 크기 요소를 가지고 있는 컴포넌트
        //  행렬을 담당하는 컴포넌트 (3D 기준 4x4 matrix)
        if (Input.GetKey(KeyCode.W))
        {
            //  Vector ? 점
            //  Vector2 -> x, y
            //  Vector3 -> x, y, z
            //  Vector4 -> x, y, z, w
            //  float -> 부동 소수점 6자리 까지 넣을 수 있다 (0.000001) f
            //  double -> 부동 소수점 12자리 까지 넣을 수 있다 ( ...... ) (d)
            //transform.position = new Vector3(
            //    transform.position.x + .1f,
            //    transform.position.y
            //    );
            //  위의 코드와 동일
            transform.Translate(0.1f, 0, 0);

        }
    }
    */

    public float Speed = 0;

    void Update()
    {
        //  Time.deltaTime ? 매 프레임 타임
        //  실습 1
        //  W, S, D, A 키 다 만들어오기!
        float frameSpeed = Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))    //  Press
        {
            transform.Translate(frameSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-frameSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))    //  Press
        {
            transform.Translate(0, 0, frameSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, -frameSpeed);
        }

        //  실습 2
        //  도로 만들고, 장애물 배치하기

        Debug.Log(Time.deltaTime);
    }
}