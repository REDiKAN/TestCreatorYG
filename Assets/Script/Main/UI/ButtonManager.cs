using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    [HideInInspector] private bool isActivSetting;

    [Header("List Button")]
    [SerializeField] private Button settingButton;

    [Header("Background")]
    [SerializeField] private Image backgroundImage;

    [Header("Setting Panel")]
    [SerializeField] private GameObject settingImage;
    public void UseSetting(bool isActiv)
    {
        if (isActiv == true)
        {

        }
        else
        {

        }
    }

    private void OffSetting()
    {
        DOTween.Sequence()
            .Append(backgroundImage.DOFillAmount(0f, 0.5f));
    }

    private void OnSetting()
    {

    }
}
