using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ResourceType
{
    Wood,
    Gold,
    Metal,
    Cereal,
    Bread,
    Meat,
    Human
};

public class Resource : MonoBehaviour
{
    public ResourceType type;
    public float amount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
