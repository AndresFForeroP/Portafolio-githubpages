using UnityEngine;
using UnityEngine.UI;

public class RpgCarGameScript : MonoBehaviour
{
    [SerializeField] Button BackButton;
    [SerializeField] Button PlayButton;
    [SerializeField] Button RepositoryButton;
    [SerializeField] GameObject RpgCarGameObject;
    [SerializeField] GameObject ButtonsGames;
    void Start()
    {
        BackButton.onClick.AddListener(Backbuttonclick);
        PlayButton.onClick.AddListener(Playbuttonclick);
        RepositoryButton.onClick.AddListener(RepositoryButtonclick);
    }
    void Playbuttonclick()
    {
        // Application.OpenURL("https://andresforero.itch.io/car-game-rpg");
    }
    void Backbuttonclick()
    {
        RpgCarGameObject.SetActive(false);
        ButtonsGames.SetActive(true);
    }
    void RepositoryButtonclick()
    {
        Application.OpenURL("https://github.com/AndresFForeroP/Rpg-Car-Game-2D-Unity");
    }
}
