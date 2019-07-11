using UnityEngine;
using UnityEngine.Events;

public class StartEvent : MonoBehaviour
{
    [SerializeField] UnityEvent OnStart;

    // Start is called before the first frame update
    void Start()
    {
        OnStart.Invoke();
    }

}
