using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // Sphere (플레이어)
    public Vector3 offset = new Vector3(0, 5, -5);  // 카메라 위치 오프셋

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset;  // 플레이어를 따라가되
            transform.LookAt(player.position);  // 플레이어를 바라보기만 하고 회전하지 않음
        }
    }
}
