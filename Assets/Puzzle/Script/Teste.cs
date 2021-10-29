using UnityEngine;
using UnityEngine.SceneManagement;

public class Teste : MonoBehaviour
{
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.buildIndex + "'.");
    }
}
