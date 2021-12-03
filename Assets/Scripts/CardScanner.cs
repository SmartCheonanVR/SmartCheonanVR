using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScanner : MonoBehaviour
{
    bool cardTagged;

    [SerializeField] Animator doorAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Card"))
        {
            UserEnter();
        }
    }
    void UserEnter()
    {
        //�Լ��� ��� ����Ǵ� �� ����
        if (!cardTagged)
        {
            print("card tagged ");

            doorAnim.Play("DoorOpen");


            cardTagged = true;
        }
    }
}
