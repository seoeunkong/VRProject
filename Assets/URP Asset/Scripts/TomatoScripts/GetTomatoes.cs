using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

// �����丶�� ���
// UI ���� (1/5, 2/5, ... 5/5)
// destroy �丶��


public class GetTomatoes : MonoBehaviour
{
    XRGrabInteractable grabInteractable = null;
    GameObject RedTomato;
    public static GetTomatoes Instance;
    public bool isDestroyed = false;

    void Awake()
    {
        this.RedTomato = GameObject.Find("Tomato_red(1)");
        grabInteractable = GetComponent<XRGrabInteractable>();

        //grabInteractable.onActivate.AddListener(DestroyRedTomato);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isDestroyed);
    }

    /*public void DestroyRedTomato(XRBaseInteractor interactor)
        
    {
        Destroy(RedTomato);


    }
    */

    /*
    private void OnCollisionEnter(Collision collision)

    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
            isDestroyed = true;
        }

       

    }
    */
}

