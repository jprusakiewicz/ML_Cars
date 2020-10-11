using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    public Button Button;
    // Start is called before the first frame update
    void Start()
    {
        Button.onClick.AddListener(TaskOnClick);
    }
    private void TaskOnClick()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
    // Update is called once per frame
}
