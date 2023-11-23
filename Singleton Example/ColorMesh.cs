using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SingletonTest.Instance.AddObj(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
