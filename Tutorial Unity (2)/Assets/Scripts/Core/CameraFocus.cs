using UnityEngine;

class CameraFocus : MonoBehaviour
{
    public Transform m_Player;
    public Vector3 CameraOffset = new Vector3(0, 2, -2); // 카메라와 플레이어 사이 거리

    private void LateUpdate()
    {
        float x = m_Player.rotation.x;
        float y = m_Player.rotation.y;
        Vector3 MoveCamera = new Vector3(x, y, 0);
        transform.position = m_Player.position + CameraOffset; // 카메라와 플레이어 사이 거리
        transform.localRotation = m_Player.rotation;
       transform.Translate(x, y, 0);

    }

}

