using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LoadLightingScene()
    {
        SceneManager.LoadScene("lightingRoom");
    }

    public void LoadProbeScene()
    {
        SceneManager.LoadScene("postProcessingSphere");
    }
}