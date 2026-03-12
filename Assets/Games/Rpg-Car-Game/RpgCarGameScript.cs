using UnityEngine;
using UnityEngine.UI;

public class RpgCarGameScript : MonoBehaviour
{
    [SerializeField] Button BackButton;
    [SerializeField] Button PlayButton;
    [SerializeField] Button RepositoryButton;
    [SerializeField] GameObject RpgCarGameObject;
    [SerializeField] GameObject ButtonsGames;
    [SerializeField] AudioSource SoundButton;
    void Start()
    {
        BackButton.onClick.AddListener(Backbuttonclick);
        PlayButton.onClick.AddListener(Playbuttonclick);
        RepositoryButton.onClick.AddListener(RepositoryButtonclick);
    }
    void Playbuttonclick()
    {
        SoundButton.Play();
    }
    void Backbuttonclick()
    {
        RpgCarGameObject.SetActive(false);
        ButtonsGames.SetActive(true);
        SoundButton.Play();
    }
    void RepositoryButtonclick()
    {
        Application.OpenURL("https://github.com/AndresFForeroP/Rpg-Car-Game-2D-Unity");
        SoundButton.Play();
    }
}
