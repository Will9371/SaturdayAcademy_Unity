using UnityEngine;

public class JumpToPosition : MonoBehaviour
{
    [SerializeField] Transform[] locations;
    private int currentLocationIndex;

    public void JumpToPoint(Transform location)
    {
        transform.position = location.position;
        transform.rotation = location.rotation;
    }

    public void CyclePosition()
    {
        currentLocationIndex++;

        if (currentLocationIndex >= locations.Length)
            currentLocationIndex = 0;

        JumpToPoint(locations[currentLocationIndex]);
    }

    public void JumpToIndex(int index)
    {
        if (index >= locations.Length || index < 0)
        {
            Debug.LogError("Invalid location index!");
            return;
        }

        currentLocationIndex = index;
        JumpToPoint(locations[currentLocationIndex]);
    }
}
