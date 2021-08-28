using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  오브젝트에 내가 만든 클래스 (스크립트) 를 넣고 싶다면 꼭 지켜야 할 공식
//  1. 클래스 이름과 파일 이름이 같아야 한다. (class SpawnCube, 솔루션 탐색기 에서는 SpawnCube.cs)
//  2. 반드시 MonoBehaviour 를 상속 받아야 한다. (class SpawnCube : MonoBehaviour)
public class SpawnCube : MonoBehaviour
{
    /*
    //  코드를 작성할 때
    int A = 0;
    int B = 0;


    //  뒤에 소괄호 "(" ")" 가 붙은 애들은 함수이다!
    //  Start() 함수는 유니티가 실행되면 함수 안에 있는 코드를 실행한다
    void Start()
    {
        //  Debug.Log ?
        //  유니티 콘솔 창에 소괄호 안에 있는 녀석을 출력한다 (보여준다)
        Debug.Log(A + B);
    }
    //  Ctrl + Shift + B 전체 빌드 (저장도됨)
    //  코드 작성 뒤 왼쪽이 초록색이면 저장됨 / 노란색은 저장 안됨
    */
    /*
    //  유니티 인스펙터 창 ( Inspector) 에서 내 클래스 안에 있는 변수를 공유하는 법!
    //  1.public 접두사를 변수 앞에 붙여준다
    //  [SerializeField] 접두사를 변수 앞에 붙여준다

    //  public 이라는 접두사가 붙으면 누구나 이 클래스 안에 있는 'A' 변수를 가져오거나 바꿀 수 있다
    public int Count = 0;
    //  처음 인스펙터에서 사용되는 값을 미리 지정할 수 있다
    //  물론 컴포넌트 마다 값을 변경할 수 있다

    //  1.  스크립트로 오브젝트 만들기
    private void Start()
    {
        //  오브젝트 생성!
        //  생성할 때는 new 라는 접두사를 붙이고 띄고 자료형(); 소괄호 해준다
        //  문자열을 넣을 떄는 반드시 쌍따옴표 " 부터 시작해서 쌍따옴표로 끝난다 "
        //  소괄호가 잇는 녀석들 팁
        //  1. 콤마 (,) 를 찍고 키보드 위 아래 Arrow 키를 누르면 추가 기능을 알 수 있다
        GameObject obj = new GameObject("내가 만든 첫 오브젝트");
        
        //  숫자나 문자를 넣을 때는 new 를 하지 않고 값을 넣어준다
        
    }
    */
    /*
    void Start()
    {
        //  반복문 첫 번째!
        //  for 문

        //  게임 오브젝트 3개 생성하는 방법
        for (int i = 0; i < 3; i++)
        {
            GameObject obj = new GameObject();
        }

        //  게임 오브젝트를 5개 생성하는 방법
       for (int z = 0; z < 5; ++z)
        {
            GameObject o = new GameObject();
        }

       //   for 주의사항!
       //   1. for ( 첫 번쨰 변수 선언할 때 int 뿐만 아니라 다른것도 넣을 수 있다)
       //   2. for ( int 변수 명 <- 은 아무거나 해도 상관 없다!)
       //   3. for ( int i = 0; i< 크기 <- for 문에서 크기까지 실행되어지지 않는다!
       //   ex) for ( float dot = 0; ..), float (int num = 0; ...)
    }
    */
    /*
    void Start()
    {
        //  게임 오브젝트 5개 생성
        //  1.  오브젝트 에다가 순서대로 번호 이름을 넣어주자
        //  2. "Node" 라는 이름에다가 번호를 부여하자
        for (int i = 0; i< 5; i++)
        {
            //ToStrint() ? 변수 값을 문자열로 변경해주는 함수
            new GameObject("Node_" + i.ToString());
        }

    }*/
    /*
    //  큐브를 생성하는 첫 번째 방법
    //  public 을 붙이면 유니티에서 수정으 가능하므르
    //  인스펙터 창 에서 내가 만든 프리팹 객체를 유니티에서 넣어주는 방법을 이용
    public GameObject CubePrefab;

    //  큐브를 생성해보자!
    void Start()
    {
        //  이 방법 말고 프리팹을 이용해서 ..
        //  GameObject.CreatePrimitive(PrimitiveType.Cube);


        // Instantiate ?  객체를 복사하여 새로 생성하는 함수
        for (int i = 0; i < 5; i++)
        {
            Instantiate(CubePrefab);
        }

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Instantiate(CubePrefab);
        }
        
    }
    */



}
