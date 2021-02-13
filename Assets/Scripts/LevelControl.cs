
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public int index;
    public string levelName;


 void OnTriggerEnter(Collider other)   
    {
        SceneManager.LoadScene(index);

        //SceneManager.LoadScene(levelName);
    }
}
