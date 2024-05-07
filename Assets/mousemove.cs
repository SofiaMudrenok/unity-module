using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;

public class mousemove : MonoBehaviour
{
    NavMeshAgent agent;
    public LayerMask FoodMask;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UnityEngine.Debug.Log("before hit");
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100, FoodMask))
            {
                UnityEngine.Debug.Log("after hit");
                agent.destination = hit.point;
            }
        }
    }
}
