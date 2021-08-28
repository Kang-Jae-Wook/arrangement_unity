using UnityEngine;

class MoveAI : MonoBehaviour
{
    public Rigidbody Rigid;
    public float Speed;
    public float JumpPower;

    private bool m_IsStop = false;

    private void FixedUpdate()
    {
        if (m_IsStop) return;
        Vector3 movement = Vector3.right * Speed* Time.deltaTime;
      
        Rigid.MovePosition(transform.position + movement);

       
        //  장애물을 만나면 AI가 점프할 수 있도록 하기

    }

    private void OnTriggerEnter(Collider other)
    {
        switch(other.name)
        {
            case "Jump Point" :
                {
                    Rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
                    break;
                }
            case "Finish Line":
                {
                    m_IsStop = true;
                    break;
                }
        }
//        if(other.name.Equals("Jump Point"))
//        {
//            Rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
//        }
//
//        if(other.name.Equals("Finish Line"))
//        {
//            m_IsStop = true;
//        }
    }
}
