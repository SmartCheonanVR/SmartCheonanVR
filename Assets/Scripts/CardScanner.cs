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
        //함수가 계속 실행되는 것 방지
        if (!cardTagged)
        {
            print("card tagged ");

            doorAnim.Play("DoorOpen");


            cardTagged = true;
        }
    }
}
