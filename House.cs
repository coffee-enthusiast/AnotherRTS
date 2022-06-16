using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class House : MonoBehaviour
{
    public float time_for_human;
    float time_passed;

    public TextMeshPro panel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (time_passed < time_for_human)
            time_passed += Time.deltaTime;
        else if (time_passed >= time_for_human)
        {
            time_passed -= time_for_human;
            GameManager.Instance.meat-= 5;
            GameManager.Instance.humen++;
            panel.text = "Humen: " + GameManager.Instance.humen;
            Debug.Log("Human!");
        }
    }
}
