using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 0.45f;
    public GameObject exposion;

    void Start()
    {

    }


    void Update()
    {
        //Y�� �̵�
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        //�̻����� ȭ������� ��������
        //�̻��� ������
        Destroy(gameObject);


    }


    //2D�浹 Ʈ�����̺�Ʈ
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�̻��ϰ� ���� �΋H����
        //if(collision.gameObject.tag == "Enemy")
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //���� ����Ʈ ����
            Instantiate(exposion, transform.position, Quaternion.identity);
            //��������
            SoundManager.instance.SoundDie(); //�� ���� ����
            //�����÷��ֱ�
            GameManager.intance.AddScore(10);
            //�������
            Destroy(collision.gameObject);
            //�Ѿ� ����� �ڱ��ڽ�
            Destroy(gameObject);
        }
    }








}