using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Image tempMeterBar;
    [SerializeField] public float percentage;

    /*[SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    private ItemBehaviour RFunction;
    private float countRoulette;*/

    void Start()
    {
        if(tempMeterBar != null)
        {
            percentage = tempMeterBar.fillAmount *100;
        }
        //countRoulette = mainTimer;
    }

    void Update()
    {
        percentage -= Time.deltaTime*4;

        if(percentage >= 100|| percentage <= 0)
        {
            percentage = ((percentage <= 0) ? 0 : 100);
        }
        tempMeterBar.fillAmount = percentage/100;
        /*countRoulette -= Time.deltaTime;

        if(countRoulette <= 0)
        {
            countRoulette = mainTimer;
            RFunction.RouletteFunction();
        }

        uiText.text = countRoulette.ToString("F0");
        */
    }

}
