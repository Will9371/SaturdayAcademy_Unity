using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void SetScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void ResetScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SetScene(scene.name);
    }
}


