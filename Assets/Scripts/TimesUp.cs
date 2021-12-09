using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class TimesUp : MonoBehaviour
{
    XRRayInteractor leftRayInteractor;
    XRRayInteractor rightRayInteractor;
    InputActionAsset xriInputAction;

    InputAction leftGrip, rightGrip;

    [SerializeField] Transform goToTitle;
    [SerializeField] Transform close;

    void Start()
    {
        leftRayInteractor = GameObject.Find("LeftHand Controller").GetComponent<XRRayInteractor>();
        rightRayInteractor = GameObject.Find("RightHand Controller").GetComponent<XRRayInteractor>();
        xriInputAction = Resources.Load<InputActionAsset>("XRI Default Input Actions_clone");

        leftGrip = xriInputAction.FindActionMap("XRI LeftHand").FindAction("Grip");
        rightGrip = xriInputAction.FindActionMap("XRI RightHand").FindAction("Grip");
    }

    // Update is called once per frame
    void Update()
    {

    }


    void ExitY(InputAction left, InputAction right)
    {
        if (left.triggered || right.triggered)
        {
            if (leftRayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit))
            {
                if (hit.transform == goToTitle)
                {
                    GotoTitle();
                }
                if (hit.transform == close)
                {
                    CloseTab();
                }
            }
            if (rightRayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hitR))
            {
                if (hitR.transform == goToTitle)
                {
                    GotoTitle();
                }
                if (hitR.transform == close)
                {
                    CloseTab();
                }
            }
        }
    }
    void GotoTitle()
    {
        SceneManager.LoadScene(0);
    }
    void CloseTab()
    {
        gameObject.SetActive(false);
    }
}
