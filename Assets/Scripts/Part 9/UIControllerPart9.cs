using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIControllerPart9 : MonoBehaviour
{
    public Button _playButton;
    public Button _settingsButton;
    public Button _exitButton;

    private void Start()
    {
        _playButton.onClick.AddListener(PlayButtonAnimation);
        _settingsButton.onClick.AddListener(SettingsButtonAnimation);
        _exitButton.onClick.AddListener(ExitButtonAnimation);
    }

    public void PlayButtonAnimation()
    {
        _playButton.transform.DOScale(1.2f, 0.2f)
            .SetEase(Ease.OutBack)
            .OnComplete(() => _playButton.transform.DOScale(1f, 0.2f));
    }

    public void SettingsButtonAnimation()
    {
        _settingsButton.transform.DORotate(new Vector3(0, 0, 30), 0.2f, RotateMode.Fast)
            .SetLoops(2, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }

    public void ExitButtonAnimation()
    {
        _exitButton.transform.DOPunchScale(Vector3.one * 0.3f, 0.5f, 10, 1)
            .SetEase(Ease.OutElastic);
    }
}
