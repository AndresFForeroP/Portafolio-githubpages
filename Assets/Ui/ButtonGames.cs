using UnityEngine;
using UnityEngine.UI;


public class ButtonGames : MonoBehaviour
{
    [SerializeField] Button RpgCarGameButton;
    [SerializeField] GameObject ButtonsGames;
    [SerializeField] GameObject CarGameRpgObject;
    
    void Start()
    {
        RpgCarGameButton.onClick.AddListener(ViewCarGameRpg);
    }
    void ViewCarGameRpg()
    {
        ButtonsGames.SetActive(false);
        CarGameRpgObject.SetActive(true);
    }

}
