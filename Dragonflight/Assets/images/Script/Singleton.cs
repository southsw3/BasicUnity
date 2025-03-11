using UnityEngine;

public class Singleton : MonoBehaviour
{
    //����Ƽ���� �̱����� ����ϸ� �ϳ��� �ν��Ͻ��� �����ϸ鼭 ��𼭵� ���� �����ϰ� ���� �� �ִ�.
    public static Singleton Instance { get; private set; }

    private void Awake() //�Լ� �ѹ� �����ϴ°ǵ� start���� �� ����
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); //���� �ٲ� �����ǰ� �ϴ� �Լ�
        }
        else
        {
            Destroy(gameObject); //�ߺ� ���� ����
        }

    }

    public void PrintMessage()
    {
        Debug.Log("�̱��� �޽��� ���!");
    }
    

}
