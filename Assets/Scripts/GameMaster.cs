using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class GameMaster : MonoBehaviour
{
    public static int randomic;
    public GameObject instantiated;
   public GameObject respawnPrefabUsable;
   public GameObject respawnPrefabUnusable;
    public GameObject[] respawns;
    
    void Start()
    {
        if (respawns == null)
            respawns = (GameObject[])FindRespawns();

    }

    void OnMouseDown()
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

    }

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
