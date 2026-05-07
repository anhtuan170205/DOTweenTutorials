using UnityEngine;
using DG.Tweening;
using UnityEngine.InputSystem;

public class CubeControllerPart8 : MonoBehaviour
{
    public GameObject _cube;
    public Tween _tween;
    private void Start()
    {
        _tween = _cube.transform.DOScale(new Vector3(5, 5, 5), 2f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (_tween.IsPlaying())
            {
                _tween.Pause();
                Debug.Log("Tween Paused");
            }
            else
            {
                _tween.Play();
                Debug.Log("Tween Resumed");
            }
        }
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            _tween.Restart();
            Debug.Log("Tween Restarted");
        }


    }
}
