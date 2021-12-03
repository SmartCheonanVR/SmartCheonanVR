using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class ControllerManager : MonoBehaviour
{
    [SerializeField] XRRayInteractor leftRayInteractor;
    [SerializeField] XRRayInteractor rightRayInteractor;
    [SerializeField] InputActionAsset xriInputAction;
    InputAction leftGrip, leftTrigger, rightGrip, rightTrigger;
    public enum ButttonType { Trigger, Grip };
    public ButttonType butttonType;

    [Header("Main Themes")]
    [SerializeField] Transform planet;
    [SerializeField] Transform blackHole;


    [Header("")]
    [SerializeField] string planetScene;
    [SerializeField] string blackHoleScene;
    void Start()
    {
        leftGrip = xriInputAction.FindActionMap("XRI LeftHand").FindAction("Grip");
        leftTrigger = xriInputAction.FindActionMap("XRI LeftHand").FindAction("Trigger");
        rightGrip = xriInputAction.FindActionMap("XRI RightHand").FindAction("Grip");
        rightTrigger = xriInputAction.FindActionMap("XRI RightHand").FindAction("Trigger");
    }

    void Update()
    {
        //� ��ư �̿����� �����ϱ�
        switch (butttonType)
        {
            case ButttonType.Grip:
                GetButton(leftGrip, rightGrip);
                break;
            case ButttonType.Trigger:
                GetButton(leftTrigger, rightTrigger);
                break;
        }
    }

    void GetButton(InputAction left, InputAction right)
    {
        if (left.triggered && right.triggered)
        {
            //2��° �濡�� �׸�����(�༺, ��Ȧ)
            SelectTheme();
        }
    }

    void SelectTheme()
    {
        if (leftRayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit))
        {
            if (hit.transform == planet)
            {
                SceneManager.LoadScene(planetScene);
            }
            if (hit.transform == blackHole)
            {
                SceneManager.LoadScene(blackHoleScene);
            }
        }
    }
}
