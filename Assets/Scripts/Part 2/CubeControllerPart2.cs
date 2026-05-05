using UnityEngine;
using DG.Tweening;

public class CubeControllerPart2 : MonoBehaviour
{
    void Start()
    {
        transform.DOMoveX(5f,2f).SetEase(Ease.InOutQuad).OnComplete(() =>
        {
            transform.DOMoveY(3f,1f).SetEase(Ease.InOutQuad);
        });
    }

    void Update()
    {
        
    }
}
