using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class DoorAnimator : MonoBehaviour
{
    private Animator _animator;

    private const string Open = "Open";

    private void OnEnable()
    {
        _animator = GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        _animator.SetBool(Open, true);
    }

    public void StopAnimation()
    {
        _animator.SetBool(Open, false);
    }
}