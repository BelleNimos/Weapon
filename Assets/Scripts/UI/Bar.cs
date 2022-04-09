using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public abstract class Bar : MonoBehaviour
{
    [SerializeField] protected Slider Slider;

    private const float FillingTime = 0.5f;

    public void OnValueChanged(int value, int maxValue)
    {
        Slider.DOValue((float)value / maxValue, FillingTime);
    }
}