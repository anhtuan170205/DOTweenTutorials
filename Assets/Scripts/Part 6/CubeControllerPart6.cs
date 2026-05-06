using UnityEngine;
using DG.Tweening;

public class CubeControllerPart6 : MonoBehaviour
{
    public GameObject _cube;
    private void Start()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(_cube.transform.DOMoveX(5f, 2f))
            .Join(_cube.transform.DOScale(new Vector3(5f, 5f, 5f), 5f))
            .Join(_cube.GetComponent<Renderer>().material.DOColor(Color.green, 5f));
    }
}
