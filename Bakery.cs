using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bakery : MonoBehaviour
{
    public float time_for_bread;
    float time_passed;
    public TextMeshPro panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time_passed < time_for_bread)
            time_passed += Time.deltaTime;
        else if(time_passed >= time_for_bread)
        {
            time_passed -= time_for_bread;
            GameManager.Instance.cereal-=3;
            GameManager.Instance.bread++;
            panel.text = "Bread: " + GameManager.Instance.bread;
            Debug.Log("Bread!");
        }
    }
}
