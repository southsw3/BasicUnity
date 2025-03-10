using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // Sphere (�÷��̾�)
    public Vector3 offset = new Vector3(0, 5, -5);  // ī�޶� ��ġ ������

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset;  // �÷��̾ ���󰡵�
            transform.LookAt(player.position);  // �÷��̾ �ٶ󺸱⸸ �ϰ� ȸ������ ����
        }
    }
}
