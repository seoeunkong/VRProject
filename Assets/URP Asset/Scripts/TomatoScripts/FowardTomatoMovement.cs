using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �丶�䰡 ������ �̵��ϴ� �ڵ�
public class FowardTomatoMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float _speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.back * _speed);
    }
}
