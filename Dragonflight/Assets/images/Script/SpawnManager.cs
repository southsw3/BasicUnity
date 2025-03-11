using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;

    //���� �����ϴ� �Լ�
    void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f); //���� ��Ÿ�� X��ǥ�� �������� �����ϱ�

        //���� �����Ѵ�. rnadomX ������ x��
        Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
    }

    void Start()
    {
        //SpawnEnemy 1�ʽ��� 0.5�ʸ��� ���� �̱� 1 0.5f
        InvokeRepeating("SpawnEnemy", 1, 0.5f);
    }

    
    void Update()
    {
        
    }
}
