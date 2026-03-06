using UnityEngine;
using UnityEngine.UI;

public class Menu2 : MonoBehaviour
{
    [SerializeField] Button ButtonProjects;
    [SerializeField] Button  ButtonLinkedin;
    [SerializeField] Button  ButtonGithub;
    [SerializeField] Button  ButtonCv;
    [SerializeField] GameObject ButtonGameInfo;
    void Start()
    {
        ButtonProjects.onClick.AddListener(Clickprojects);
        ButtonLinkedin.onClick.AddListener(Clicklinkedin);
        ButtonGithub.onClick.AddListener(Clickgithub);
        ButtonCv.onClick.AddListener(Clickcv);    
    }
    void Clickprojects()
    {
        ButtonProjects.interactable = false;
        ButtonGameInfo.SetActive(true);
    }
    void Clicklinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/andres-forero-p%C3%A9rez-34a4563aa/");
    }
    void Clickgithub()
    {
        Application.OpenURL("https://github.com/AndresFForeroP");
    }
    void Clickcv()
    {
        Application.OpenURL("https://drive.google.com/file/d/1CPA4CSkeAdFm0j9H-XRuTiIkAvtWnEs3/view?usp=sharing");
    }
}
