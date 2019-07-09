using UnityEngine;
using UnityEngine.Events;

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
