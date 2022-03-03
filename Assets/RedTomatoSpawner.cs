

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �丶�� ������
public class RedTomatoSpawner : MonoBehaviour
{
    public GameObject TomatoPrefab;
    public Transform[] spawnPoint;

    public static double waitingTime;  // ��� �ð�(���� �� ������ ������ ��ٸ��� �ð�)
    float timeAfterSpawn; // �������� �ð�



    void Start()
    {
        timeAfterSpawn = 0;
        waitingTime = 4;
    }

    void Update()
    {
        Spawn();


    }

    void Spawn()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= waitingTime)
        {
            int spawnPos = Random.Range(0, spawnPoint.Length);

            GameObject tomato = Instantiate(TomatoPrefab, spawnPoint[spawnPos].position, spawnPoint[spawnPos].rotation);  // ��ġ, ȸ���� ����

            timeAfterSpawn = 0;




        }

    }


}