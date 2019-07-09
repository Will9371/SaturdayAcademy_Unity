using UnityEngine;
using UnityEngine.Events;

// Attach this to an object to make something happen when it collides with another object
// Supports trigger and non-trigger collisions.
public class ContactEvent : MonoBehaviour
{
    // Set this to only trigger events on collisions with a specific object
    // Leave unset to trigger event on collision with any object
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
