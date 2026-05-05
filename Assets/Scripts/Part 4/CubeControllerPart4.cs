using UnityEngine;
using DG.Tweening;

public class CubeControllerPart4 : MonoBehaviour
{
    public Transform _cube;
    private void Start()
    {
        _cube.DOScale(new Vector3(5f, 5f, 5f), 2f).SetEase(Ease.InOutQuad).OnComplete(() =>
        {
            _cube.DOScale(new Vector3(1f, 1f, 1f), 2f).SetEase(Ease.InOutQuad);
        });
    }
}
