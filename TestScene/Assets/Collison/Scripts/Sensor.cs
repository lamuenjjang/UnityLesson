using UnityEngine;
using UnityEngine.Video;

public class Sensor : MonoBehaviour
{
    private VideoPlayer video;

    void Start()
    {
        video.GetComponent<VideoPlayer>();
    }


    //�������� ������ �������� �ʰ� �浹�� ������ �����ϴ� �Լ�
    private void OnTriggerEnter(Collider other)
    {
        video.Play();   
    }

    //�������� ������ �������� �ʰ� �浹�� �϶� �����ϴ� �Լ�
    private void OnTriggerStay(Collider other)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);   
    }

    //�������� ������ �������� �ʰ� �浹�� ������� �����ϴ� �Լ�
    private void OnTriggerExit(Collider other)
    {
        video.Stop();
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}

