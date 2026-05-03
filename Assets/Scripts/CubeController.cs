using UnityEngine;
using DG.Tweening;

public class CubeController : MonoBehaviour
{
    void Start()
    {
        transform.DOMoveX(5f, 2f).OnComplete(() =>
        {
            transform.DOMoveY(3f, 1f);
        });
    }

    void Update()
    {
        
    }
}
