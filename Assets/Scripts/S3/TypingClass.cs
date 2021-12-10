using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingClass : MonoBehaviour
{
    // Showing UI Text
    public Text DialogText;

    // Main Text
    public string originText;

    // Planaet Text
    public string mercuryText;
    public string venusText;
    public string earthText;
    public string marsText;
    public string jupiterText;
    public string saturnText;
    public string uranusText;
    public string neptuneText;
    public string noneText;

    // SubString Variable
    string subText;

    void Start()
    {
        mercuryText = "����\n����: 4õ 8�� km (������ 0.38��)\n�߷�: 0.38g\n�¾����κ��� �Ÿ�: 5õ�� km\n�����ֱ�: 59��\n�����ֱ�: 88��\n�µ�:179��";
        venusText = "�ݼ�\n����: 2�� 4õ km (������ 0.95��)\n�߷�: 0.9g\n�¾����κ��� �Ÿ�: 1�� km\n�����ֱ�: 243��\n�����ֱ�: 224��\n�µ�: 467��";
        earthText = "����\n����: 1�� 2õ 8�� km\n�߷�: 1g\n�¾����κ��� �Ÿ�: 1�� 5õ�� km\n�����ֱ�: 1��\n�����ֱ�: 365��\n�µ�: 17��";
        marsText = "ȭ��\n����: ������ 0.5��\n�߷�: 0.38g\n�¾����κ��� �Ÿ�: 2�� 3õ��km\n�����ֱ�: 1��\n�����ֱ�: 687��\n�µ�: -80��";
        jupiterText = "��\n����: 14�� km\n�߷�: 2.5g\n�¾����κ��� �Ÿ�: 7�� 8õ��km\n�����ֱ�: 10�ð�\n�����ֱ�: 12��\n�µ�: -148��";
        saturnText = "�伺\n����: ������ 9.4��\n�߷�: 0.9g\n�¾����κ��� �Ÿ�: 14�� km\n�����ֱ�: 10�ð�\n�����ֱ�: 29��\n�µ�: -176��";
        uranusText = "õ�ռ�\n����: ������ 4��\n�߷�: 0.9g\n�¾����κ��� �Ÿ�: 28�� km\n�����ֱ�: 17�ð�\n�����ֱ�: 84��\n�µ�: -215��";
        neptuneText = "�ؿռ�\n����: ������ 3.9��\n�߷�: 1.14g\n�¾����κ��� �Ÿ�: 45�� km\n�����ֱ�: 16�ð�\n�����ֱ�: 165��\n�µ�: -214��";
        noneText = "";

        //StopCoroutine("TypingAction");
        //StartCoroutine("TypingAction");
    }

    // Used Coroutine
    public IEnumerator TypingAction()
    {
        DialogText.text = "";

        for (int i = 0; i < originText.Length; i++)
        {
            yield return new WaitForSeconds(0.05f);

            subText += originText.Substring(0, i);
            DialogText.text = subText;
            subText = "";
        }
    }
}
