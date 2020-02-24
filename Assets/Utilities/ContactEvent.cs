using UnityEngine;
using UnityEngine.Events;

// Attach this to an object to make something happen when it collides with another object
// Supports trigger and non-trigger collisions.
public class ContactEvent : MonoBehaviour
{
    public RefTypes targetType;
    
    // Set this to only trigger events on collisions with a specific object
    // Leave unset to trigger event on collision with any object
    public Collider target; 

    public UnityEvent OnEnter;
    public UnityEvent OnExit;

    private void Start()
    {
        GameObject targetObject = SceneRefs.instance.GetObject(targetType);
        Debug.Log(targetObject);
        
        if (targetObject != null)
        {
            target = targetObject.GetComponent<Collider>();
        }
    }   

    private void OnCollisionEnter(Collision other)
    {
       if (IsValidContact(other.collider)) 
            OnEnter.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsValidContact(other)) 
            OnEnter.Invoke();
    }

    private void OnCollisionExit(Collision other)
    {
       if (IsValidContact(other.collider)) 
            OnExit.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (IsValidContact(other)) 
            OnExit.Invoke();
    }

    private bool IsValidContact(Collider other)  
    {
        return other == target;
    }
} 
