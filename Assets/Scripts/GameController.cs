using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    private float countRoulette;

    void Start()
    {
        countRoulette = mainTimer;
    }

    void Update()
    {
        countRoulette -= Time.deltaTime;

        if(countRoulette <= 0)
        {
            countRoulette = mainTimer;
        }

        uiText.text = countRoulette.ToString("F0");
    }

}
