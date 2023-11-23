using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    public static SingletonTest Instance { get; private set; } = null;

    public Color RngColor { get; private set; } = Color.red;

    private List<MeshRenderer> obj = new List<MeshRenderer>();

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this.gameObject);
        RngColor = Random.ColorHSV();
    }


    public void AddObj(GameObject other)
    {
        if (other.TryGetComponent(out MeshRenderer meshRenderer))
        {
            obj.Add(meshRenderer);

            RngColor = Random.ColorHSV();

            foreach (MeshRenderer child in obj)
            {
                other.GetComponent<MeshRenderer>().material.color = RngColor;
            }

        }


    }

}
