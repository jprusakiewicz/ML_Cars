using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject Car;
    // Start is called before the first frame update
    void Start()
    {
        var playerColor = PlayGame.playerColor;
        if (playerColor != -1)
        {
            Car.GetComponent<Renderer>().material.color = Color.HSVToRGB(playerColor, 1, 1);;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
