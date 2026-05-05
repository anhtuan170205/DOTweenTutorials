using UnityEngine;
using DG.Tweening;

public class CubeControllerPart3 : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;

    private void Start()
    {
        cube1.transform.DOMoveX(5f, 2f).SetEase(Ease.InOutQuad).SetDelay(0f);
        cube2.transform.DOMoveX(5f, 2f).SetEase(Ease.InOutQuad).SetDelay(1f);
        cube3.transform.DOMoveX(5f, 2f).SetEase(Ease.InOutQuad).SetDelay(2f);
    }
}
