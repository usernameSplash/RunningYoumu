using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BackgroundController : MonoBehaviour
{
    MeshRenderer[] Quads;
    float[] Speeds = { 0.05f, 0.1f, 0.2f, 0.4f };

    // Start is called before the first frame update
    void Start()
    {
        Quads = gameObject.GetComponentsInChildren<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Quads.Length; i++)
        {
            Quads[i].material.mainTextureOffset += new Vector2(Speeds[i] * Time.deltaTime, 0.0f);
        }
    }
}
