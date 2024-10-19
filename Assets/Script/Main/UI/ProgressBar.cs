using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using DG.Tweening;
using UniRx;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private int numberQuestions;

    [Header("Setting")]
    [SerializeField] private GameObject interactivInterfase;
    [SerializeField] private Image progressImg;

    public void SetActivProgressBar(bool isActiv)
    {
        if (isActiv)
        { DOTween.Sequence().Append(interactivInterfase.GetComponent<CanvasGroup>().DOFade(1f, 0.5f)); }
        else
        { DOTween.Sequence().Append(interactivInterfase.GetComponent<CanvasGroup>().DOFade(0f, 0.5f)); }

        if (interactivInterfase.GetComponent<CanvasGroup>().alpha == (isActiv==false?0:1)) { Debug.LogError($"¬ы повторно попыталс€ взаимодействовать с InteractivInterfase," +
                        $" и применили ей тоже значение которое уже было указано ранее ({isActiv}). " +
                        $"| —оветует проверить DATA TEST! \n є101"); }
    }

    public void AddProgress(int progres)
    {
        DOTween.Sequence().Append(progressImg.DOFillAmount((progressImg.fillAmount + progres) / 100, 0.5f));
    }
    public void SetProgress(int progres)
    {
        DOTween.Sequence().Append(progressImg.DOFillAmount((progressImg.fillAmount - progres) / 100, 0.5f));
    }

    public void UseProgress()
    {
        DOTween.Sequence().Append(progressImg.DOFillAmount((progressImg.fillAmount + 1) / numberQuestions, 0.5f));
    }
}
