using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// FireSpawner�� ����
// �� ���� ��ġ �迭�� ���� �� �� ���� ������ ��ġ�� �������� ����
public class FireSpawner : MonoBehaviour
{
    public GameObject firePrefab; // ������ �� ���� ����
    public Transform[] spawnPoint1;  // 1�� ���� �� ���� ��ġ ���� �迭 ����
    public Transform[] spawnPoint2;  // 2�� ���� �� ���� ��ġ ���� �迭 ����

    float waitingTime;  // ��� �ð�(���� �� ������ ������ ��ٸ��� �ð�)
    float timeAfterSpawn; // �������� �ð�

    // �� ���� ����(���� 1,2�� ���ο��� �����ư��� �����Ǿ�� ��, ����x)
    private bool yesFire1;
    private bool yesFire2;


    void Start()
    {
        yesFire1 = true; // 1�� ���ο��� �����Ǿ�� �ϴ� ����
        yesFire2 = false;
        timeAfterSpawn = 0;
        waitingTime = 4f; // ���� �� 2�� �Ŀ� ����
    }

    void Update()
    {
        if (yesFire1 == true && yesFire2 == false)
            Spawn1();

        if (yesFire1 == false && yesFire2 == true)
            Spawn2();

    }

    void Spawn1() // 1�� ����
    {
        timeAfterSpawn += Time.deltaTime;  // ���� �ð� ������

        if (timeAfterSpawn >= waitingTime)
        {
            int spawnPos1 = Random.Range(0, spawnPoint1.Length); // 1�� ���� �迭 ���� �� �������� ����

            GameObject fire = Instantiate(firePrefab, spawnPoint1[spawnPos1].position, spawnPoint1[spawnPos1].rotation);  // ��ġ, ȸ���� ����
            Destroy(fire, 1);  // 1�� �� �� �����

            timeAfterSpawn = 0;

            yesFire1 = false;
            yesFire2 = true;

        }

    }

    void Spawn2() // 2�� ����
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= waitingTime)
        {
            int spawnPos2 = Random.Range(0, spawnPoint2.Length); // 2�� ���� �迭 ���� �� �������� ����
            GameObject fire2 = Instantiate(firePrefab, spawnPoint2[spawnPos2].position, spawnPoint2[spawnPos2].rotation);
            Destroy(fire2, 1); // 1�� �� �� �����

            timeAfterSpawn = 0;

            yesFire2 = false;
            yesFire1 = true;

        }

    }
}
