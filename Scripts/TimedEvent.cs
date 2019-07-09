using UnityEngine;
using UnityEngine.Events;

// Make something happen after a specified interval of time
public class TimedEvent : MonoBehaviour
{
    public UnityEvent OnEnd;

    public void Begin(float duration)
    {
        Invoke("End", duration);
    }

    private void End()
    {
        OnEnd.Invoke();
    }
}
