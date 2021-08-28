using UnityEngine;

public class Movement : MonoBehaviour
{
    //  캐릭터 이동
    //  마우스 위치로 캐릭터 회전
    public Rigidbody rigid;
    public float Speed;
    public float Rotate;
    public Camera cam;

    private void CameraFocus()
    {

    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(h, 0, v);

        movement = Speed * Time.deltaTime * movement;

        rigid.MovePosition(transform.position + movement);
//        float speed = Speed * Time.deltaTime;
//        if(Input.GetKey(KeyCode.W))
//        {
//            transform.Translate(speed, 0, 0);
//        }
//        else if (Input.GetKey(KeyCode.S))
//        {
//            transform.Translate(-speed, 0, 0);
//        }
//        if(Input.GetKey(KeyCode.A))
//        {
//            transform.Translate(0, 0, -speed);
//        }
//        else if (Input.GetKey(KeyCode.D))
//        {
//            transform.Translate(0, 0, speed);
//        }
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       


        if (Physics.Raycast(ray,out RaycastHit hit, Mathf.Infinity))
        {
            Vector3 point = hit.point - transform.position;
            point.y = transform.position.y;

            rigid.MoveRotation(Quaternion.LookRotation(point));

        }
        
    }


}
