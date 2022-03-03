using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2���� 4�� ��ġ�� ���������� �������� ����ϴ� Ŭ����
public class panController24 : MonoBehaviour
{
    Rigidbody rb;

    // speed 
    public float speed = 1.3f;

    // ���������� �����̴� �ð� 
    private float lastSpawnTime = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // �ð��� 4 �����̸�
        if (lastSpawnTime < 4)
        {
            // ����(y��)���� 5 * speed�� �ӵ��� ������
            rb.velocity = new Vector3(0, 2 * speed, 0);
        }
        // �ð��� 5 �̻��� �Ǹ�
        else if (lastSpawnTime >= 5)
        {
            // �Ʒ���(-y��)���� 300��ŭ ���ӵ��� �ο���
            rb.AddForce(1, -300, 1);
        }

        // �ð� �ø��� 
        lastSpawnTime += Time.deltaTime;

    }

    // ���������� plane(�ٴ�)�� �ε��� ��� �ð��� 0���� ������ Update�Լ� �ȿ��� �ݺ��ǵ��� ��
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Grill")
        {
            lastSpawnTime = 0;
        }
    }
}
