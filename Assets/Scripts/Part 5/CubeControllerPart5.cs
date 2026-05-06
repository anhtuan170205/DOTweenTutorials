using UnityEngine;
using DG.Tweening;

public class CubeControllerPart5 : MonoBehaviour
{
    public GameObject _cube;
    void Start()
    {
        Sequence seq = DOTween.Sequence();

        seq.Append(_cube.transform.DORotate(new Vector3(0, 180, 0), 2f))
            .Append(_cube.transform.DORotate(new Vector3(180, 180, 0), 2f))
            .Append(_cube.transform.DOScale(new Vector3(5f, 5f, 5f), 2f));
    }
}