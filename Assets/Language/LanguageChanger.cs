using UnityEngine;
using UnityEngine.Localization.Settings;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class LanguageChanger : MonoBehaviour
{
    [SerializeField] Button EnglishButton;
    [SerializeField] Button SpanishButton;
    [SerializeField] GameObject LanguageUI;
    [SerializeField] AudioSource Sountrack;
    [SerializeField] AudioSource SoundButton;
    CanvasGroup canvasGroup;
    void Start()
    {
        EnglishButton.onClick.AddListener(()=>{SetLanguage("en");});
        SpanishButton.onClick.AddListener(()=>{SetLanguage("es");});
        canvasGroup = LanguageUI.GetComponent<CanvasGroup>();
    }
    public void SetLanguage(string idlanguage)
    {
        StartCoroutine(ChangeLocale(idlanguage));
        SoundButton.Play();
    }
    IEnumerator ChangeLocale(string code)
    {
        yield return LocalizationSettings.InitializationOperation;
        var locales = LocalizationSettings.AvailableLocales.Locales;

        foreach (var locale in locales)
        {
            if (locale.Identifier.Code == code)
            {
                LocalizationSettings.SelectedLocale = locale;
                break;
            }
        }
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
        Sequence seq = DOTween.Sequence();
        seq.Join(canvasGroup.DOFade(0.01f,1f)).OnComplete(GoToGame);
    }
    public void GoToGame()
    {
        LanguageUI.SetActive(false);
        Sountrack.volume = 0.4f;
    }
}