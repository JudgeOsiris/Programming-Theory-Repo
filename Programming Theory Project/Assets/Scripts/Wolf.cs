using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : Animal // Inheritance
{
    public override void DisplayAnimalType() // Polymorphism
    {
        Debug.Log("Animal type: " + AnimalType);
    }

    private void Awake()
    {
        Initialize(); // Abstraction
    }

    private void Initialize()
    {
        AnimalType = "Wolf";
        LimbsCount = 4;
        isVertebrate = true;
        speed = 1.3f;
    }


}
