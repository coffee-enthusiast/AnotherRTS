using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Farm : MonoBehaviour
{
    public float time_for_meat;
    float time_passed;
    public TextMeshPro panel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (time_passed < time_for_meat)
            time_passed += Time.deltaTime;
        else if (time_passed >= time_for_meat)
        {
            time_passed -= time_for_meat;
            GameManager.Instance.cereal-=3;
            GameManager.Instance.meat++;
            panel.text = "Meat: " + GameManager.Instance.meat;
            Debug.Log("Meat!");
        }
    }
}
