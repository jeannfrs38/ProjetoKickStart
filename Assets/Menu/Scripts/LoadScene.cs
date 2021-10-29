using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Load(string scene)
    {
        SceneManager.LoadScene(scene);
        if(Time.timeScale == 0){
            Time.timeScale = 1;
        }
    }
}
