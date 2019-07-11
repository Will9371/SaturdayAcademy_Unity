using UnityEngine;
using UnityEngine.Events;

// Make something happen after a specified interval of time
public class TimedEvent : MonoBehaviour
{
    [SerializeField] UnityEvent OnEnd;

    public void Begin(float duration)
    {
        Invoke("End", duration);
    }

    private void End()
    {
        OnEnd.Invoke();
    }
}
