using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Awake()
    {
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
