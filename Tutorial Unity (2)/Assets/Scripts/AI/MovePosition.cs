using UnityEngine;

class MovePosition : MonoBehaviour
{
    public Rigidbody Rigid;
    public float Speed;
    public float JumpPower;

    public bool GroundCheck = true;


    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(v, 0, -h);
        movement = Speed * Time.deltaTime * movement;

        Rigid.MovePosition(transform.position + movement);

        //  Jump
        //  AddForce ? 강체에 힘을 준다 ( 물체에 힘을 넣어준다)
        //  힘은 Velocity 변수로 알 수 있다 (Rigid.velocity, Vector3)
        //  Vector3.up -> new Vector3( 0, 1, 0)
        //  ForceMode.Force -> 힘을 주는데 자연스럽게 주는 경우
        //  ForceMode.Impulse - > 힘읋 빡! 주는 경우(충돌)   

        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !GroundCheck)
        {
             Rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
             GroundCheck = true;
        }
    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.name.Equals("Plane")) 
        {
            GroundCheck = false;
        }

        //  if (other.tag == "Ground")
        //      GroundCheck = false;
        //  if (other.tag == "Object")
        //      GroundCheck = false;
    }


}