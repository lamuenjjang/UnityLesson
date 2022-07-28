using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Various : MonoBehaviour
{
    private float timer;
    public Image stateimage;
    public Sprite[] stateicon;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("함수",p,q) : 특정한 함수를 p초 뒤에 실행하고 q초마다 반복하도록 설정하는 함수입니다.
        InvokeRepeating("Position", 1, 3);

        StartCoroutine(Paint());
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 5.0f)
        {
            Invoke("ChangeSprite", 0);

            timer = 0.0f;
        }
    }

    public void ChangeSprite()
    {
        switch(Random.Range(0,3))
        {
            case 0: stateimage.sprite = stateicon[0];
                break;
            case 1: stateimage.sprite = stateicon[1];
                break;
            case 2: stateimage.sprite = stateicon[2];
                break;
        }
    }

    public void Position()
    {
        transform.position = new Vector3 
            (
            Random.Range(-2.5f,2.5f),
            0,
            Random.Range(-2.5f,2.5f)
            );
    }
    public IEnumerator Paint()
    {
      while (true)
        {
            yield return new WaitForSeconds(3.0f);

            gameObject.GetComponent<Renderer>().material.color = 
                new Color(
                    Random.Range(0, 2), 
                    Random.Range(0, 2), 
                    Random.Range(0, 2)
                    );
        }
    }

    //메인루틴 : 실제로 동작하는 루틴 ex) start, update
    //서브루틴 : 메인루틴에 있는 것을 실행 후 리턴
    //코루틴

    //CPU 유휴 시간 : CPU가 놀고있는 시간
}
