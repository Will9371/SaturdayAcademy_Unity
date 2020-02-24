using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class AnimationProgressEvent : MonoBehaviour 
{
    [SerializeField] Animator animator;
    [SerializeField] PercentEvent[] actions;
    [SerializeField] bool overrideInputValidation;

    public bool Completed { get { return CurrentPercent >= 1f; } }
    public float CurrentPercent { get { return StateInfo.normalizedTime; } }
    public AnimatorStateInfo StateInfo { get { return animator.GetCurrentAnimatorStateInfo(0); } }
    
    // Enforce valid input: events organized by increasing percent threshold
    private void OnValidate()
    {
        if (overrideInputValidation)
            return;
    
        for (int i = 0; i < actions.Length - 1; i++)
            if (actions[i].percent > actions[i + 1].percent)
                actions[i].percent = actions[i + 1].percent;
    }
    
    public void Play(string name)
    {
        StopAllCoroutines();
        StartCoroutine(AnimTimer(name));
    }

    IEnumerator AnimTimer(string name)
    { 
        animator.Play(name);
        yield return null;
        
        var fullDuration = StateInfo.length;
        
        for (int i = 0; i < actions.Length; i++)
        {
            var priorPercent = i == 0 ? 0f : actions[i - 1].percent;
            var delayPercent = actions[i].percent - priorPercent;
            var duration = fullDuration * delayPercent;

            yield return new WaitForSeconds(duration);
            actions[i].OnReached.Invoke();
        }
    }
}

[Serializable]
public struct PercentEvent
{
    [Range(0f, 1f)] public float percent;
    public UnityEvent OnReached;
}
