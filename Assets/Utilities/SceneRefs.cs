using UnityEngine;
using Playcraft;

// Allows anything (including prefabs!) to find specific objects in the scene
public class SceneRefs : Singleton<SceneRefs>
{
    public GameObject Player;

    public GameObject GetObject(RefTypes type)
    {
        switch (type)
        {
            case RefTypes.Player: return Player;
            default: return null;
        }
    }
}

public enum RefTypes
{
    None,
    Player
}
