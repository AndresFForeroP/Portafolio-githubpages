using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ButtonSound : MonoBehaviour
{
    [SerializeField] Button SoundButton;
    [SerializeField] Image ButtonImage;
    [SerializeField] Sprite SpriteOn;
    [SerializeField] Sprite SpriteOf;
    [SerializeField] AudioSource SoundPressButton;
    public bool mute = false;
    void Start()
    {
        SoundButton.onClick.AddListener(Mute);
    }
    public void Mute()
    {
        SoundPressButton.Play();
        mute = !mute;
        AudioListener.pause = mute;
        ButtonImage.sprite = mute ? SpriteOf : SpriteOn;
    }

}
