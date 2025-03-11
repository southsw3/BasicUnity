using UnityEngine;

public class Enemy : MonoBehaviour
{
    //������ �ӵ��� ������ �ش�.
    public float moveSpeed = 1.3f;
    void Start()
    {
        
    }

     
    void Update()
    {
        //������ �Ÿ��� ����� �ش�.
        float distanceY = moveSpeed * Time.deltaTime;

        //�������� �ݿ��Ѵ�.
        transform.Translate(0, -distanceY, 0);
    }

    //ȭ�� ������ ���� ī�޶󿡼� ������ ������ ȣ��ȴ�.
    private void OnBecameInvisible()
    {
        Destroy(gameObject); //��ü�� �����Ѵ�.
    }
}
