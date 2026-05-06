using UnityEngine;
using DG.Tweening;

public class CubeControllerPart7 : MonoBehaviour
{
    public GameObject _cube;

    private void Start()
    {
        _cube.transform.DOScale(new Vector3(5, 5, 5), 2f).SetLoops(-1, LoopType.Yoyo);
    }
}
