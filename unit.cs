using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class unit : MonoBehaviour
{

    public NavMeshAgent navAg;
    public float time_to_eat;
    float time_passed;

    public ResourceType collectRes;
    public float time_to_collect;
    float time_to_collect_passed;


    public TextMeshPro metal;
    public TextMeshPro cereal;
    public TextMeshPro gold;
    public TextMeshPro wood;

    // Use this for initialization
    void Start()
    {

    }

    public void SetDestination(Vector3 dest)
    {
        navAg.SetDestination(dest);
    }

    // Update is called once per frame
    void Update()
    {

        if (time_passed < time_to_eat)
            time_passed += Time.deltaTime;
        else if (time_passed >= time_to_eat)
        {
            time_passed -= time_to_eat;
            GameManager.Instance.meat--;
            GameManager.Instance.bread--;
            Debug.Log("Eat!");
        }


        if (time_to_collect > 0 && time_to_collect_passed < time_to_collect)
            time_to_collect_passed += Time.deltaTime;
        else if (time_to_collect > 0 && time_to_collect_passed >= time_to_collect)
        {
            time_to_collect_passed -= time_to_collect;
            if(collectRes == ResourceType.Cereal)
                GameManager.Instance.cereal++;
            else if (collectRes == ResourceType.Metal)
                GameManager.Instance.metal++;
            else if (collectRes == ResourceType.Gold)
                GameManager.Instance.gold++;
            else if (collectRes == ResourceType.Wood)
                GameManager.Instance.wood++;

            metal.text = "Metal: " + GameManager.Instance.metal;
            cereal.text = "Cereal: " + GameManager.Instance.cereal;
            gold.text = "Gold: " + GameManager.Instance.gold;
            wood.text = "Wood: " + GameManager.Instance.wood;
            Debug.Log("Eat!");
        }
    }
}
