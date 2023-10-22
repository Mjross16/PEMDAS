using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MianMenu : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenOptions()
    {
        cam.transform.position = new Vector3(transform.position.x,10,-10);
    }

    public void OpenAchievements()
    {
        cam.transform.position = new Vector3(transform.position.x, -4, -10);
    }

    public void OpenExtra()
    {
        cam.transform.position = new Vector3(transform.position.x, -18, -10);
    }

    public void QuitGame()
    {
        cam.transform.position = new Vector3(transform.position.x, -32, -10);
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
