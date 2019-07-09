using UnityEngine;
using UnityEngine.Events;

public class ContactEvent : MonoBehaviour
{
    [SerializeField] GameObject objectOfInterest;
    [SerializeField] UnityEvent OnEnter, OnExit;

    private void OnTriggerEnter(Collider other)
    {
        if (objectOfInterest != null && objectOfInterest != other.gameObject)
            return;

        OnEnter.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (objectOfInterest != null && objectOfInterest != other.gameObject)
            return;

        OnExit.Invoke();
    }

    private void OnCollisionEnter(Collision other)
    {
        OnTriggerEnter(other.collider);
    }

    private void OnCollisionExit(Collision other)
    {
        OnTriggerExit(other.collider);
    }
} 
