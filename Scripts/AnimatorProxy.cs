﻿using UnityEngine;

public class AnimatorProxy : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void TriggerAnimation(string animationName)
    {
        animator.SetTrigger(animationName);
    }

    public void ToggleAnimation(string animationName)
    {
        bool currentState = animator.GetBool(animationName);
        animator.SetBool(animationName, !currentState);
    }
}