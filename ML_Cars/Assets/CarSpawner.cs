using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject playerCar;
    public GameObject enemyCar1;
    public GameObject enemyCar2;
    public GameObject enemyCar3;
    public GameObject enemyCar4;
    public GameObject enemyCar5;

    public List<GameObject> enemys;
    // Start is called before the first frame update
    void Start()
    {
        enemys.Add(enemyCar1);
        enemys.Add(enemyCar2);
        enemys.Add(enemyCar3);
        enemys.Add(enemyCar4);
        enemys.Add(enemyCar5);
        var playerColor = PlayGame.playerColor;
        if (playerColor != -1)
        {
            playerCar.GetComponent<Renderer>().material.color = Color.HSVToRGB(playerColor, 1, 1);
            var enemyColor = playerColor;

            foreach (var enemy in enemys)
            {
               
                enemyColor += 0.16f;
                if (enemyColor > 1)
                    enemyColor = enemyColor - 1;
                Debug.Log(enemyColor);
                enemy.GetComponent<Renderer>().material.color = Color.HSVToRGB(enemyColor, 1, 1);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
