using System.Collections;
using UnityEngine;

public class CoroutineStudy : MonoBehaviour
{

    //    C# ����Ƽ �ڷ�ƾ(Coroutine) ����
    //�ڷ�ƾ�� �Ϲ����� �Լ��� �޸� ������ ����ٰ� �ٽ� �̾ ������ �� �ִ� ����̾�.
    //�̸� �̿��ϸ� ���� �ð� �� ����ǰų�, Ư�� ������ ��ٸ��� ���� ����� ���� ������ �� �־�! 

    void Start()
    {
        //  StartCoroutine("ExampleCoroutine");
        StartCoroutine(ExampleCoroutine());
    }


    IEnumerator ExampleCoroutine()
    {
        while (true)
        {
            Debug.Log("�� 1�ʸ��� ����!");
            yield return new WaitForSeconds(1f);   //2�ʴ��
        }
    }







}