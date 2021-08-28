using System.Collections;
using UnityEngine;

class RotateMoveKeyboard : MonoBehaviour
{
    public Rigidbody rigdig;
    public float Speed = 5;
    public float RotateSpeed = 10;
    
    //  Rigidbody ? 강체 물리 움직임을 위해 사용되는 컴포넌트
    //  NVDIA - Physics
    
    /*
    void Update()
    {
        
        float speed = Speed * Time.deltaTime;
        float rotateSpeed = RotateSpeed * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed);
        }
        else if(Input.GetKey(KeyCode.S))
        {

            transform.Translate(0, 0, -speed);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotateSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotateSpeed, 0);
        }



    }
    */
    private void FixedUpdate()
    {
        float speed = Speed * Time.deltaTime;
        float rotateSpeed = RotateSpeed * Time.deltaTime;
       
        /*
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = transform.position + new Vector3(0, 0, speed);
            rigdig.MovePosition(position);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = transform.position + new Vector3(0, 0, -speed);
            rigdig.MovePosition(position);
        }

        if(Input.GetKey(KeyCode.A))
        {

            Quaternion rotation = Quaternion.Euler(
                transform.rotation.x,
                transform.rotation.y - rotateSpeed,
                transform.rotation.z);

            rigdig.MoveRotation(rotation);
        }
        else if (Input.GetKey(KeyCode.A))
        {

            Quaternion rotation = Quaternion.Euler(
                transform.rotation.x,
                transform.rotation.y + rotateSpeed,
                transform.rotation.z);

            rigdig.MoveRotation(rotation);
        }
        */
    }

}
