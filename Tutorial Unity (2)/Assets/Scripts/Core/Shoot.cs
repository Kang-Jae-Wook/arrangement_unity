using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Cube 클릭하면 클릭한 큐브 날려버리기
   public float Power;

   void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        float power = Power * Time.deltaTime;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
        {
            Rigidbody rigid = hit.collider.GetComponent<Rigidbody>();
            if (rigid != null)
            {
                rigid.AddForceAtPosition(Vector3.forward * power, hit.point, ForceMode.Impulse);
            }
        }
    }


}
