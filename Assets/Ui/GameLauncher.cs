using System.Runtime.InteropServices;
using UnityEngine;

public class GameLauncher : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void OpenGameInOverlay(string url);

    public void LaunchGame(string gameUrl)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        OpenGameInOverlay(gameUrl);
#else
        Application.OpenURL(gameUrl);
#endif
    }
}