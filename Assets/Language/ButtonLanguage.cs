using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLanguage : MonoBehaviour
{
    [SerializeField] Button ButtonChangeLanguage;
    [SerializeField] GameObject UiLanguage;
    [SerializeField] AudioSource Sountrack;
    [SerializeField] AudioSource SoundPressButton;
    CanvasGroup canvasGroup;

    void Start()
    {
        ButtonChangeLanguage.onClick.AddListener(ChangeLanguage);
        canvasGroup = UiLanguage.GetComponent<CanvasGroup>();
    }
    void ChangeLanguage()
    {
        SoundPressButton.Play();
        Sountrack.volume = 0.18f;
        UiLanguage.SetActive(true);
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
        Sequence seq = DOTween.Sequence();
        seq.Join(canvasGroup.DOFade(1f,1f));
    }
}