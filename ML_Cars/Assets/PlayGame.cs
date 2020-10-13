using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    public Button Button_Play;
    public Button Button_Quit;
    public Slider Colour_picker;

    public GameObject Car;
    static public float playerColor = -1;
    public Material CarColour;
    // Start is called before the first frame update
    void Start()
    {
        Button_Play.onClick.AddListener(PlayGameTaskOnClick);
        Button_Quit.onClick.AddListener(QuitGameTaskOnClick);
        Colour_picker.onValueChanged.AddListener(CarColourChanged);
    }

    private void CarColourChanged(float colourValue)
    {
        var color = Color.HSVToRGB(colourValue, 1, 1);
       // CarColour.SetColor("user_color",Color.magenta);
        Car.GetComponent<Renderer>().material.color = color;
        playerColor = colourValue;
    }

    private void PlayGameTaskOnClick()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
    private void QuitGameTaskOnClick()
    {
        Application.Quit();
    }
    // Update is called once per frame
}
