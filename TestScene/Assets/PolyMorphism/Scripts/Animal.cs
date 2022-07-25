using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public int age;
    public string name;
    
    void Start()
    {
        Dog dog = new Dog();
        Cat cat = new Cat();
        Duck duck = new Duck();
        dog.Sound();
        cat.Sound();
        duck.Sound();
    }

    public void Sound() 
    {
        Debug.Log("�����Ҹ�");
    }

    public void information()
    {
        Debug.Log("Age : " + age);
        Debug.Log("name : " + name);
    }
}
public class Dog : Animal
{
    public void Sound() 
    {
        Debug.Log("�۸�");
    }
    public Dog()
    {
        age = 5;
        name = "Dog";
        information();
    }
}
public class Cat : Animal
{
    public void Sound()
    {
        Debug.Log("�߿�");
    }
    public Cat()
    {
        age = 3;
        name = "Cat";
        information();
    }
}
public class Duck : Animal
{
    public void Sound()
    {
        Debug.Log("�в�");
    }
    public Duck()
    {
        age = 1;
        name = "Duck";
        information();
    }
}