using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //�̱���
    public static SoundManager instance; //�ڱ��ڽ��� ������ ���

    AudioSource myAudio; //AudioSource ������Ʈ�� ������ ��´�.
    public AudioClip SoundBullet; //����ҼҸ�
    public AudioClip soundDie; //�״� ����
    private void Awake()
    {
        if (SoundManager.instance == null)  //�ν��Ͻ��ִ��� �˻�
        {
            SoundManager.instance = this; //�ڱ��ڽ��� ��´�.
        }
    }


    void Start()
    {
        myAudio = GetComponent<AudioSource>(); //AudioSource ������Ʈ ��������
    }

    public void PlayBulletSound()
    {
        myAudio.PlayOneShot(SoundBullet);
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie); //���� ��������
    }


}