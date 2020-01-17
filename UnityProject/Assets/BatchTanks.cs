using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatchTanks : MonoBehaviour
{
    void Start()
    {
        StaticBatchingUtility.Combine(gameObject);
    }
}
