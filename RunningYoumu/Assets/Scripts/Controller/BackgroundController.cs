using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// WaitForSeconds 객체를 매번 새로 생성하면 프로그램이 느려질 수 있어 Object Pooling 기법을 이용함
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
