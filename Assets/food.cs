using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        Destroy(gameObject);
    }
}