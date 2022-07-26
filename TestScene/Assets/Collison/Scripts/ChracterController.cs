using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterController : MonoBehaviour
{
    bool condition;
    public float speed;

    Rigidbody rigid;
    Vector3 direction;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if(Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            rigid.AddForce(new Vector3(0, 200, 0));
            condition = false;
        }
    }

    private void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + direction.normalized * speed * Time.fixedDeltaTime);
    }

    //물리 충돌에 관여하는 함수
    //1. 충돌을 했을떄 : OnCollisionEnter()
    //2. 충돌 중일때 : OnCollisionStay()
    //3. 충돌에서 벗어났을때 : OnCollisionExit()

    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }
    private void OnCollisionStay(Collision collision)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
    private void OnCollisionExit(Collision collision)
    {
        condition = false;
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
