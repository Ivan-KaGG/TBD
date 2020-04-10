using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public int randomic;
    private Collider myCollider;
    public GameObject instantiated;
    public GameObject myPrefabUsable;
    public GameObject myPrefabUnusable;

    void Start()
    {
        myCollider = GetComponent<Collider>();
    }
    void OnMouseDown()
    {
        randomic = Random.Range(0,2);
        Debug.Log(randomic);

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

        }else if(gameObject.tag=="unusable")
        {
            Debug.Log("<color=red>Unusable</color>");
        }

        if(gameObject.transform.position.x== -2.7f)
        {
            Destroy(gameObject);
            Instantiate(instantiated, new Vector3(-2.7f,-2.2f,0), Quaternion.identity);
            
        }else if(gameObject.transform.position.x== -1.7f)
        {
            Destroy(gameObject);
            Instantiate(instantiated, new Vector3(-1.7f,-2.2f,0), Quaternion.identity);
            
        }   

        if(!myCollider.enabled)
        {
            Debug.Log("isn't enabled");
        }             
        
    }
}
