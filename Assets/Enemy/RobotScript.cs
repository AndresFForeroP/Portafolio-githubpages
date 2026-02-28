using System.Collections;
using DG.Tweening;
using UnityEngine;

public class RobotScript : MonoBehaviour
{
 [Header("Shake Settings")]
    public float firstDelay = 1f;      // Primera sacudida
    public float repeatDelay = 1.2f;   // Intervalo después de la primera

    public float duration = 0.25f;
    public float strength = 4f;
    public int vibrato = 20;
    public float randomness = 90f;

    private Vector3 originalPos;
    private Tween shakeTween;

    void Start()
    {
        originalPos = transform.localPosition;
        StartCoroutine(ShakeLoop());
    }

    IEnumerator ShakeLoop()
    {
        // Espera inicial
        yield return new WaitForSeconds(firstDelay);

        while (true)
        {
            DoShake();
            yield return new WaitForSeconds(repeatDelay);
        }
    }

    void DoShake()
    {
        shakeTween?.Kill();

        shakeTween = transform.DOShakePosition(
            duration,
            strength,
            vibrato,
            randomness,
            false,
            true
        )
        .OnComplete(() =>
        {
            transform.localPosition = originalPos;
        });
    }

    void OnDisable()
    {
        shakeTween?.Kill();
        transform.localPosition = originalPos;
    }
}
