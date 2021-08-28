using System.Collections;
using UnityEngine;

public class HitClick : MonoBehaviour
{
    public float Go = 150.0f;
    void Update()
    {
        
        if (!Input.GetMouseButtonDown(0)) return;
        float go = Go * Time.deltaTime;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray,out RaycastHit hit, Mathf.Infinity))
        {
            Rigidbody rigid = hit.collider.GetComponent<Rigidbody>();
          if(rigid != null)
            {
                //  AddFoeceAtPosition ? 힘을 가할 떄 특정 위치에 힘을 가하는 함수
                rigid.AddForceAtPosition(Vector3.forward * go,hit.point, ForceMode.Impulse);
            }
        }
    }

}
