using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knifeplayermove : MonoBehaviour
{
    int a = 1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x > 0.2f) // ���� 0.2f
        {
            a = 1;
        }
        else if (transform.localPosition.x < -2.0f) //���� 0.0f
        {
            a = -1;
        }

        transform.Translate(Vector3.left * 0.3f * Time.deltaTime * a);
    }
}
