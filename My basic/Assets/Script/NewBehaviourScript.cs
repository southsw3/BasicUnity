using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int playerScore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�������
        Debug.Log("Player Name : " + playerName);
        Debug.Log("Player Score : " + playerScore);
        Debug.Log("Speed : " + speed);
        Debug.Log("Is Game Over? : " + isGameOver);
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
