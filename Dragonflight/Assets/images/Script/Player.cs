using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;


    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        //������ Axis�� ���� Ű�� ������ �Ǵ��ϰ� �ӵ��� ������ ������ ���� �̵����� ���Ѵ�.
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //�̵�����ŭ ������ �̵��� ���ִ� �Լ�
        transform.Translate(distanceX, 0, 0);
    }
}
