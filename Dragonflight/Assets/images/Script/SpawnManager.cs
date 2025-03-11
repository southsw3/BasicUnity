using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;

    //적을 생성하는 함수
    void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f); //적이 나타날 X좌표를 랜덤으로 생성하기

        //적을 생성한다. rnadomX 랜덤한 x값
        Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
    }

    void Start()
    {
        //SpawnEnemy 1초쉬고 0.5초마다 몬스터 뽑기 1 0.5f
        InvokeRepeating("SpawnEnemy", 1, 0.5f);
    }

    
    void Update()
    {
        
    }
}
