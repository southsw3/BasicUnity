using UnityEngine;

public class launcher : MonoBehaviour
{
    public GameObject bullet; //�̻��� ������ ������ ����

    void Start()
    {
        //InvokeRepeating(�Լ��̸�,�ʱ������ð�, ������ �ð�)
        InvokeRepeating("Shoot", 0.5f, 0.5f);
    }

    void Shoot()
    {
        //�̻��� ������, ����������, ���Ⱚ ����
        Instantiate(bullet, transform.position, Quaternion.identity);

        SoundManager.instance.PlayBulletSound();

    }



    void Update()
    {

    }
}