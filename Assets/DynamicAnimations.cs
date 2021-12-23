using DG.Tweening;
using System;
using UnityEngine;

public class DynamicAnimations : MonoBehaviour
{
    public Transform objectForMoving;
    public Ease ease;
    void Start()
    {
        TweenObject();
    }

    private void TweenObject()
    {
        objectForMoving.localPosition = Vector3.left * 2f;
        if (enabled)
        {
            var sequence = DOTween.Sequence();
            sequence.Append(objectForMoving.DOLocalMove(new Vector3(2, 0, 0), 1f).SetEase(ease)).Append(objectForMoving.DOLocalMove(new Vector3(-2, 0, 0), 1f).SetEase(ease));
            sequence.onComplete = TweenObject;
            sequence.Play();
        }
    }
}
