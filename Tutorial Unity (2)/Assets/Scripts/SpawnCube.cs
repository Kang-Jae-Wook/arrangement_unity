using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  오브젝트에 내가 만든 클래스 (스크립트) 를 넣고 싶다면 꼭 지켜야할 공식
//  1. 클래스 이름과 파일 이름이 같아야 한다. (class SpawnCube, 솔류션 탐색기 에서는 SpawnCube.cs)
//  2. 반드시 MonoBehaviour 를 상속 받아야 한다. (class SpawnCube : MonoBehaviour)
public class SpawnCube : MonoBehaviour
{
    /*
    //  코드를 작성할 때 
    //  int, float, double 등등.. 변수!
    //  int 는 소수점 없는 숫자를 약 21억 가지 넣을 수 있다!
    //  변수의 선언법!
    //  자료형 띄고 변수명; 또는
    //  자료형 띄고 변수명 띄고 = 값
    //  int A;
    //  int A = 10;
    int A = 2;
    int B = 0;

    //  Start ?
    //  뒤에 소괄호 "(" ")" 가 붙은 애들은 함수이다!
    //  함수는 값을 보내거나 코드를 실행할 수 있도록 도와준다
    //  Start() 함수는 유니티가 실행되면 함수 안에 있는 코드를 실행한다
    void Start()
    {
        //  Debug.Log ?
        //  유니티 콘솔 창에 소괄호 안에 있는 녀석을 출력한다 (보여준다)
        Debug.Log(A + B);
    }

    //  항상 코드를 작성한 뒤 왼쪽을 보면 노란색 또는 초록색으로 불이 들어오는데
    //  초록색은 저장됨, 노란색은 저장 안됨 을 표시한다
    //  반드시 코드 작업을 한 후에는 Ctrl + S (저장) 또는 Ctrl + Shift + S (전체 저장) 을 해야
    //  유니티에서 읽을 수 있다!
    */

    /*
    //  유니티 인스펙터 창 (Inspector) 에서 내 클래스 안에 있는 변수를 공유하는 법!
    //  1. public 접두사를 변수 앞에 붙여준다
    //  2. [SerializeField] 접두사를 변수 앞에 붙여준다

    //  public 이라는 접두사가 붙으면 누구나 이 클래스 안에 있는
    //  'Count' 변수를 가져오거나 바꿀 수 있다
    public int Count = 10;
    //  처음 인스펙터에서 사용되는 값을 미리 지정할 수 있다
    //  물론 컴포넌트 마다 값을 변경할 수 있다

    //  1. 스크립트로 오브젝트 만들기
    void Start()
    {
        //  오브젝트 생성!
        //  생성할 때는 new 를 앞에 붙여준다!
        //  주의사항!
        //  생성할 때는 new 라는 접두사를 붙이고 띄고 자료형(); 소괄호 해준다
        //  문자열을 넣을 때는 반드시 쌍따옴표 " 부터 시작해서 쌍따옴표로 끝난다 "
        //  소괄호가 있는 녀석들 팁
        //  1. 콤마 (,) 를 찍고 키보드 위 아래 Arrow 키를 누르면 추가 기능을 알 수 있다
        GameObject obj = new GameObject("내가 만든 첫 오브젝트");

        //  int, double, float 등등
        //  숫자나 문자를 넣을 때는 new 를 하지 않고 값을 넣어준다
        //  반대로, 숫자나 문자를 제외하고는 모두 new 를 붙여준다
        //  NOT  -> Count = new int(); 이렇게 만들지 않는다!
        //  GOOD -> Count = 55;
    }
    */

    /*
    void Start()
    {
        //  반복문 첫 번째!
        //  for 문
        //  for 문 사용하는 법
        //  for (변수, 크기, 행할 공식) { 반복 될 때 마다 실행될 코드 }
        //  ex) 0 부터 10 까지 증가하면서 실행
        //  for (int i = 0; i < 10; ++i) { 실행 코드 }
        
        //  게임 오브젝트를 3개 생성하는 방법
        //  아래 for 문은 모두 결과가 동일하다!
        //  i 가 0 이고, i 가 3 보다 작을 때 까지 중괄호 안에 있는 녀석을 실행한다
        //  중괄호 끝까지 실행되면 ++i 는 i + 1 해주고 다시 중괄호 위로 돌아온다
        for (int i = 0; i < 3; ++i)
        {
            GameObject obj = new GameObject();
        }

        //  게임 오브젝트를 3개 생성하는 방법
        //  z 가 0 이고, z 가 2 와 같거나 작을 때 까지 중괄호 안에 있는 녀석을 실행한다
        //  중괄호 끝까지 실행되면 ++z 는 z + 1 해주고 다시 중괄호 위로 돌아온다
        for (int z = 0; z <= 2; ++z)
        {
            GameObject o = new GameObject();
        }

        int num = 10;
        //  num 은 0 으로 값을 바꾸고 시작. num 이 3이 아닐 때 중괄호 안에 있는 녀석을 실행한다
        //  중괄호 끝까지 실행되면 num = num + 1 는 num + 1 해주고 다시 중괄호 위로 돌아온다
        for (num = 0; num != 3; num = num + 1)
        {
            GameObject c = new GameObject();
        }

        //  for 주의사항!
        //  1. for (첫 번째 변수 선언할 때 int 뿐만 아니라 다른것도 넣을 수 있다)
        //  2. for (int 변수 명 <- 은 아무거나 해도 상관 없다!)
        //  ex) for (float dot = 0; ..), float (int num = 0; ...)
        //  3. for (int i = 0; i < 크기 <- for 문에서 크기까지 실행되어지지 않는다!
        //  for (int i = 0; i < 3; ++i) 에서 int Number = 0; 이라는 변수가 있을 때
        //  {
        //      Number = Number + i;
        //  }
        //  코드를 쭉 읽어보면 ..
        //  i = 0 일 때 { 0 = 0 + 0; }
        //  i = 1 일 때 { 0 = 0 + 1; }
        //  i = 2 일 때 { 1 = 1 + 2; }
        //  Number 는 3
        //  총 크기 만큼 3번 돌지만 i 가 3일 때 까지 실행되어지지 않는다
    }
    */

    /* 오브젝트 생성 예제 코드
    void Start()
    {
        //  게임 오브젝트 5개 생성
        //  1. 오브젝트 에다가 순서대로 번호 이름을 넣어주자
        //  2. "Node" 라는 이름에다가 번호를 부여하자 (ex : Node_0, Node_1 ...)
        for (int i = 0; i < 5; ++i)
        {
            //  ToString() ? 변수 값을 문자열로 변경해주는 함수
            new GameObject("Node_" + i.ToString());
        }
    }
    */

    /*  큐브를 생성하는 첫 번째 방법
    //  public 을 붙이면 유니티에서 수정이 가능하므로
    //  인스펙터 창 에서 내가 만든 프리팹 객체를 유니티에서 넣어주는 방법을 이용
    public GameObject CubePrefab;

    //  큐브를 생성해보자!
    void Start()
    {
        //  이 방법 말고 프리팹을 이용해서 ..
        //  GameObject.CreatePrimitive(PrimitiveType.Cube)

        //  Instantiate ? 객체를 복사하여 새로 생성하는 함수
        //  Instantiate(CubePrefab);

        //  위에 있는 CubePrefab 을 10번 복사하는 코드 채팅창으로 입력!
        for (int i = 0; i < 10; ++i)
        {
            Instantiate(CubePrefab);
        }
    }
    */
    //  큐브가 한 자리에 너무 많아서 펑 하고 옆으로 밀려버려요!


}
