using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] XRRayInteractor rightRayInteractor;
    [SerializeField] InputActionAsset xriInputAction;
    [SerializeField] Transform collider;

    InputAction rightTrigger;
    public enum ButttonType { Trigger };
    public ButttonType butttonType;

    void Start()
    {
        rightTrigger = xriInputAction.FindActionMap("XRI RightHand").FindAction("Trigger");
    }

    void Update()
    {
        //어떤 버튼 이용할지 선택하기
        switch (butttonType)
        {
            case ButttonType.Trigger:
                GetButton(rightTrigger);
                break;
        }
    }
    void GetButton(InputAction right)
    {
        Debug.Log("1");
        if (right.triggered)
        {
            Debug.Log("2");

            if (rightRayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hitR))
            {
                Debug.Log("3");
                if (hitR.transform.CompareTag("Changer"))
                {
                    SceneManager.LoadScene(2);
                    Debug.Log("4");
                }
            }
        }
    }
}