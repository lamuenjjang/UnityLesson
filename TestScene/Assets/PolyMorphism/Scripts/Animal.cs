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
        Debug.Log("匡澜家府");
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
        Debug.Log("港港");
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
        Debug.Log("具克");
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
        Debug.Log("残残");
    }
    public Duck()
    {
        age = 1;
        name = "Duck";
        information();
    }
}