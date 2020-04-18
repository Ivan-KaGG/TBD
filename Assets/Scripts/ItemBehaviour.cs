using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public int randomic;
    public GameObject instantiated;
    public GameObject myPrefabUsable;
    public GameObject myPrefabUnusable;

    void OnMouseDown()
    {
        randomic = Random.Range(0,2);

        if(randomic == 0)
        {
            instantiated = myPrefabUnusable;
        }else
        {
            instantiated = myPrefabUsable;
        }

        if(gameObject.tag=="usable")
        {
            Debug.Log("Usable");
            Destroy(gameObject);
            Instantiate(instantiated, new Vector3(-2.7f,-2.2f,0), Quaternion.identity);
            
        }else if(gameObject.tag=="unusable")
        {
            Debug.Log("<color=red>Unusable</color>");
            Destroy(gameObject);
            Instantiate(instantiated, new Vector3(-1.7f,-2.2f,0), Quaternion.identity);
            
        }

        Debug.Log(randomic);
        
    }
}
