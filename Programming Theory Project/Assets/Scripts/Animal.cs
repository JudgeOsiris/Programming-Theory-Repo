using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public string AnimalType { get; protected set; } // Encapsulation
    public int LimbsCount { get; protected set; } // Encapsulation
    public float speed { get; protected set; } = 1; // Encapsulation
    protected bool isVertebrate;

    private void Update()
    {
        Move(); // Abstraction
    }

    public void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public abstract void DisplayAnimalType(); // Abstraction

}
