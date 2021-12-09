using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float curTime;

    GameObject popUpPrefab;
    GameObject popUp;

    public GameObject cam;
    private void Start()
    {
        popUpPrefab = Resources.Load<GameObject>("Prefabs/TimesUpUI");
    }
    bool isActive;
    void Update()
    {
        curTime += Time.deltaTime;
        if (curTime > 120)
        {
            if (!isActive)
            {
                isActive = true;
                print(0000);
                cam = GameObject.FindGameObjectWithTag("MainCamera");
                popUp = GameObject.Instantiate(popUpPrefab,cam.transform);

                //popUp.transform.position = Vector3.zero;
                //popUp.transform.eulerAngles = Vector3.zero;
            }

            //popUppre = popUp;
        }
        //if (popUp != null)
        //{
        //    popUp.transform.parent = cam.transform;
        //}
    }
}
