using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    protected int health;
    protected int attack;
    protected string name;

    public void information()
    {
        print(health);
        print(attack);
        print(name);
    }
}

public class Memory : Monster
{
    
    // Start is called before the first frame update
    void Start()
    {
        int value = 250;
        value = 100;

        health = 20;
        attack = 10;
        name = "Goblin";
        information();
        calculate(10);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += new Vector3(1, 1, 0)*Time.deltaTime;
    }

    private void calculate(int x)
    {
        x = 10 + x;
        print(x);
    }
    // void : 자료형이 존재하지 않는다
}
