using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class GameMaster : MonoBehaviour
{
    public int randomic;
    public GameObject instantiated;
    public GameObject respawnPrefabUsable;
    public GameObject respawnPrefabUnusable;
    public GameObject[] respawns;

    public Image tempMeterBar;
    [SerializeField] public float percentage;
    
    void Start()
    {
        if (respawns == null)
        {
            respawns = (GameObject[])FindRespawns();
        }
        if(tempMeterBar != null)
        {
            percentage = tempMeterBar.fillAmount *100;
        }

    }

    void Update()
    {
        percentage -= Time.deltaTime*4;

        if(percentage >= 100|| percentage <= 0)
        {
            percentage = ((percentage <= 0) ? 0 : 100);
        }
        tempMeterBar.fillAmount = percentage/100;

        if(Input.GetMouseButtonDown(0))
        {
            randomic = UnityEngine.Random.Range(0,2);

            if(randomic == 0)
            {
                instantiated = respawnPrefabUsable;
            }else
            {
                instantiated = respawnPrefabUnusable;
            }
            foreach (GameObject respawn in respawns)
            {
                if(respawn.gameObject.CompareTag("usable"))
                {
                    Instantiate(respawnPrefabUsable, respawn.transform.position, respawn.transform.rotation);

                }else if(respawn.gameObject.CompareTag("unusable"))
                {
                    Instantiate(respawnPrefabUnusable, respawn.transform.position, respawn.transform.rotation);
                }
            
            }
        }
    }

    /*void OnMouseDown()
    {

        randomic = UnityEngine.Random.Range(0,2);
        Debug.Log(randomic);

        if(randomic == 0)
        {
            instantiated = respawnPrefabUsable;
        }else
        {
            instantiated = respawnPrefabUnusable;
        }

        if(gameObject.tag=="usable")
        {
            Debug.Log("Usable");

        }else if(gameObject.tag=="unusable")
        {
            Debug.Log("<color=red>Unusable</color>");
        }

        foreach (GameObject respawn in respawns)
        {
            if(gameObject.tag=="usable")
            {
                Instantiate(respawnPrefabUsable, respawn.transform.position, respawn.transform.rotation);

            }else if(gameObject.tag=="unusable")
            {
                Instantiate(respawnPrefabUnusable, respawn.transform.position, respawn.transform.rotation);
            }
            
        }

    }*/

    public Array FindRespawns()
    {
        GameObject[] usables;
        GameObject[] unusables;
        Array resp;

        usables = GameObject.FindGameObjectsWithTag("usable");
        unusables = GameObject.FindGameObjectsWithTag("unusable");

        resp = usables.Concat(unusables).ToArray();
        Debug.Log(resp);

        return resp;
    }
}
