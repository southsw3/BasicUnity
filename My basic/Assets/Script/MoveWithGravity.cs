using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{

    public Rigidbody rb;

    public float jumpForce = 5.0f; //���� ��
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Space Ű�� ������ ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Rigidbody: ����ȿ���� �߰��� �߷��� ����.
            //AddForce: ������ ���� ������Ʈ�� ���� �ݴϴ�.
            //ForceMode.Impulse: ���������� ���� ���ϴ� �ɼ�

            rb.AddForce(Vector3.up *jumpForce ,ForceMode.Impulse);
        }
    }
}
