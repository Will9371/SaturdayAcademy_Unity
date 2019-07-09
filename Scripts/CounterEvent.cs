using UnityEngine;
using UnityEngine.Events;

public class CounterEvent : MonoBehaviour
{
    public int target;
    public bool repeat;
    public UnityEvent OnValueReached;

    private int current;
    private bool disabled;

    public void Increment()
    {
        if (disabled)
            return;

        current++;

        if (current >= target)
        {
            OnValueReached.Invoke();

            if (!repeat)
                disabled = true;
            
            current = 0;
        }
    }
}
