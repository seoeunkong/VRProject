using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver02 : MonoBehaviour
{
    //Trap trap;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //���� ���� �ε����� 2�� ��쿡(�� â���� ���� ���)
        if (Trap.index == 2)
        {
            StartCoroutine(GoBackToStorage());
            Trap.index = 0;
        }
        if (RacingIndex.index == 7)
        {
            StartCoroutine(GoBackToRacing());
            RacingIndex.index = 0;
        }
        if (KitchenIndex.index == 4)
        {
            StartCoroutine(GoBackToKitchen());
            RacingIndex.index = 0;
        }

    }

    IEnumerator GoBackToStorage()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("storage");

    }

    IEnumerator GoBackToRacing()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("racing");

    }

    IEnumerator GoBackToKitchen()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("kitchen02");

    }
}