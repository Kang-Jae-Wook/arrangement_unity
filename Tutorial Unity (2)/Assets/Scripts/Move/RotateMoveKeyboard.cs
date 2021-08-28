using System.Collections;
using UnityEngine;

public class RotateMoveKeyboard : MonoBehaviour
{
    public Rigidbody rigid;
    public float Speed = 5;
    public float RotateSpeed = 10;

    //  Rigidbody ? 강체 물리 움직임을 위해 사용되는 컴포넌트
    //  NVDIA - Physics
    //  Constraints
    //  - Freeze Position -> 다른 물체와 충돌했을 때 이 객체의 포지션을 바꾸지 마라
    //  ?? 스크립트로 움직이는건 괜찮은데 외부 충격은 무시하라!
    //  - Freeze Rotation -> 위와 동일. 회전값을 적용

    void FixedUpdate()
    {
        //float speed = Speed * Time.deltaTime;
        //float rotateSpeed = RotateSpeed * Time.deltaTime;

        #region transform.Translate() 함수 사용법
        /*
            주석 다는법
        //  Ctrl + K 누른 상태로, C 
        //  Ctrl + K 누른 상태로, U
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotateSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotateSpeed, 0);
        }
        */
        #endregion

        //  Input.GetAxis -> Smoothing filtering value (스무딩 필터링 벨류) 
        //  위의 함수는 조이스틱 민감도에 따라 0 에서부터 1 사이 값을 준다
        //  Input.GetAxisRaw -> 필터링이 없음. 무조건 0 또는 1
        //  "Horizontal" ? "Vertical" -> 수평, 수직 값을 받는 문자열
        //   File -> Project Settings (Ctrl + Shift + B) -> Player Setting -> Input Manager
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(h, 0, v);
        movement = Speed * Time.deltaTime * movement;

        rigid.MovePosition(transform.position + movement);
    }

    public Transform rayObject;

    void Update()
    {
        //  Input -> GetMouseButton(0 이면 왼쪽 클릭, 1 이면 오른쪽 클릭, 2 이면 휠 클릭)
        //  나머지 4, 5, 6 은 마우스 셋팅에 따라 다름
        //if (Input.GetMouseButtonDown(0))
        {
            //  플레이어가 마우스 위치를 바라보게 만들기
            //  스크린 포인트의 좌표계는 x 는 오른쪽으로 갈 수록, y 는 위로 갈 수록 증가한다
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //  Ray 를 사용하여 레이저를 쏘았을 때 맞은 Collider 객체를 가져온다
            //  단, 주의사항
            //  1. Z 축 기준으로 맨 처음 맞은 객체를 가져온다
            //  2. LayerMask 사용 시 반드시 LayerMask.GetMask() 를 사용해야한다!
            //  2-1. LayerMask.NameToLayer() 를 사용할 경우 비정상 동작할 수 있다
            //  Layer ? 
            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, LayerMask.GetMask("Water")))
            {
                Vector3 point = hit.point - transform.position;
                point.y = transform.position.y;

                rigid.MoveRotation(Quaternion.LookRotation(point));

                rayObject.position = hit.point;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Gizmos.DrawLine(ray.origin, rayObject.position);
    }

}