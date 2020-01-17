using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMaterial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var t = GetComponent<MeshRenderer>().material;
        t.SetFloat("_Metallic", Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
