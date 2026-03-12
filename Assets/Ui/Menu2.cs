using UnityEngine;
using UnityEngine.UI;
using System;

public class Menu2 : MonoBehaviour
{
    [SerializeField] Button ButtonProjects;
    [SerializeField] Button ButtonLinkedin;
    [SerializeField] Button ButtonGithub;
    [SerializeField] Button ButtonCv;
    [SerializeField] GameObject ButtonGameInfo;
    [SerializeField] AudioSource SoundButton;

    private const string URL_LINKEDIN = "https://www.linkedin.com/in/andres-forero-p%C3%A9rez-34a4563aa/";
    private const string URL_GITHUB   = "https://github.com/AndresFForeroP";
    private const string URL_CV       = "https://drive.google.com/file/d/1CPA4CSkeAdFm0j9H-XRuTiIkAvtWnEs3/view?usp=sharing";

    void Start()
    {
        ButtonProjects.onClick.AddListener(OnClickProjects);
        RegisterURLButton(ButtonLinkedin, URL_LINKEDIN);
        RegisterURLButton(ButtonGithub,   URL_GITHUB);
        RegisterURLButton(ButtonCv,       URL_CV);
    }

    void RegisterURLButton(Button button, string url)
    {
        button.onClick.AddListener(() => {
            SoundButton.Play();
            Application.OpenURL(url);
        });
    }

    void OnClickProjects()
    {
        ButtonProjects.interactable = false;
        ButtonGameInfo.SetActive(true);
        SoundButton.Play();
    }
}