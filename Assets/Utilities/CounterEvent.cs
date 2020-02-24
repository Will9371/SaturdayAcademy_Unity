using UnityEngine;
using UnityEngine.Events;

// Make something happen when Increment is called a specified number of times
public class CounterEvent : MonoBehaviour
{
    [SerializeField] int target;
    [SerializeField] bool repeat;
    [SerializeField] UnityEvent OnValueReached;

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
