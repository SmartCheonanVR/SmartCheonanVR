using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class CardScanner : MonoBehaviour
{
    [SerializeField] Animator doorAnim;
    bool cardTagged;

    //grab�Ŀ� ī�� ���ϸ��̼� ���� ����
    GameObject card;
    XRGrabInteractable isGrabbed;
    Animator anim;
    private void Start()
    {
        card = GameObject.FindGameObjectWithTag("Card");
        isGrabbed = card.GetComponent<XRGrabInteractable>();
        anim = card.GetComponent<Animator>();
    }
    private void Update()
    {
        if (isGrabbed.isSelected)
            anim.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == card)
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
