using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int hp = 100;

    public string name = "KMH";

    public float height = 171.3f;

    public char bloodtype = 'A';
    void Start()
    {
        Debug.Log(hp);
        print(hp);
        print(name);
        print(height);
        print(bloodtype);
    }
    void Update()
    {
    }
}
