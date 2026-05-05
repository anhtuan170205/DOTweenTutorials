using UnityEngine;
using DG.Tweening;

public class CubeControllerPart3 : MonoBehaviour
{
    public GameObject _cube1;
    public GameObject _cube2;
    public GameObject _cube3;

    private void Start()
    {
        _cube1.transform.DOMoveX(5f, 2f).SetEase(Ease.InOutQuad).SetDelay(0f);
        _cube2.transform.DOMoveX(5f, 2f).SetEase(Ease.InOutQuad).SetDelay(1f);
        _cube3.transform.DOMoveX(5f, 2f).SetEase(Ease.InOutQuad).SetDelay(2f);
    }
}
