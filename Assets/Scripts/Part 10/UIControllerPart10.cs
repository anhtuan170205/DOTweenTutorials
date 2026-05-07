using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIControllerPart10 : MonoBehaviour
{
    public RectTransform[] _buttons;
    public CanvasGroup _canvasGroup;
    public float _duration = 0.5f;
    public float _delayBetweenButtons = 0.1f;

    private void Start()
    {
        SlideInButtons();
        _canvasGroup.DOFade(1, _duration).SetEase(Ease.InOutSine);
    }

    void SlideInButtons()
    {
        for (int i = 0; i < _buttons.Length; i++)
        {
            RectTransform button = _buttons[i];

            Vector2 targetPosition = button.anchoredPosition;
            button.anchoredPosition = new Vector2(-Screen.width, targetPosition.y);

            button.DOAnchorPos(targetPosition, _duration)
                .SetEase(Ease.OutBack)
                .SetDelay(i * _delayBetweenButtons);
        }
    }
}
