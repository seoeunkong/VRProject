using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �밢������ �̵��ϴ� �丶�� ��Ʈ�ѷ�2
public class RedTomato2 : MonoBehaviour
{
    private Vector3 lastVelocity;
    private Rigidbody rb;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        lastVelocity = rb.velocity;
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Wall")
        {
            ContactPoint cp = col.contacts[0];
            lastVelocity = Vector3.Reflect(lastVelocity, cp.normal);
            rb.velocity = lastVelocity;
        }
    }
}
