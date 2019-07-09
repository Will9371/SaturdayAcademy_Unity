using UnityEngine;

// Allows UnityEvents to print to the console
public class DebugProxy : MonoBehaviour
{
    public void Print(string message)
    {
        Debug.Log(message);
    }
}
