using UnityEngine;
using DG.Tweening;
public class Mage : MonoBehaviour
{
    public float bobAmount = 3f;      // píxeles (si usas PPU 100, esto sería 0.03f en mundo)
    public float duration = 1.2f;

    private Vector3 startPos;
    private Vector3 startScale;

    void Start()
    {
        startPos = transform.localPosition;
        startScale = transform.localScale;

        transform.DOLocalMoveY(startPos.y + 0.03f, duration)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);

        transform.DOScale(startScale * 1.01f, duration)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
    }
    // linea de prueba
}
