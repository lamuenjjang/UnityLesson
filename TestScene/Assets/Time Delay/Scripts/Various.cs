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
        //InvokeRepeating("�Լ�",p,q) : Ư���� �Լ��� p�� �ڿ� �����ϰ� q�ʸ��� �ݺ��ϵ��� �����ϴ� �Լ��Դϴ�.
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

    //���η�ƾ : ������ �����ϴ� ��ƾ ex) start, update
    //�����ƾ : ���η�ƾ�� �ִ� ���� ���� �� ����
    //�ڷ�ƾ

    //CPU ���� �ð� : CPU�� ����ִ� �ð�
}
