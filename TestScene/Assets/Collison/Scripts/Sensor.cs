using UnityEngine;
using UnityEngine.Video;

public class Sensor : MonoBehaviour
{
    private VideoPlayer video;

    void Start()
    {
        video.GetComponent<VideoPlayer>();
    }


    //물리적인 연산을 수행하지 않고 충돌을 했을때 감지하는 함수
    private void OnTriggerEnter(Collider other)
    {
        video.Play();   
    }

    //물리적인 연산을 수행하지 않고 충돌중 일때 감지하는 함수
    private void OnTriggerStay(Collider other)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);   
    }

    //물리적인 연산을 수행하지 않고 충돌을 벗어났을때 감지하는 함수
    private void OnTriggerExit(Collider other)
    {
        video.Stop();
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}

