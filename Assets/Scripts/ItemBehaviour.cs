using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemBehaviour : MonoBehaviour
{
    public static int randomic;
    public GameObject instantiated;
    public GameObject myPrefabUsable;
    public GameObject myPrefabUnusable;
        
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
            //Debug.Log(tempPlus.percentage);

        }else if(gameObject.tag=="unusable")
        {
            //GameController.percentage -= 10.0f;
            Debug.Log("<color=red>Unusable</color>");
        }

        RouletteFunction();

    }

    public void RouletteFunction()
    {
        if(gameObject.transform.position.x== -2.73f)
        {
            Instantiate(instantiated, new Vector3(-2.73f,-2.25f,0), Quaternion.identity);
            Destroy(this.gameObject);
            
        }else if(gameObject.transform.position.x== -1.7f)
        {
            Instantiate(instantiated, new Vector3(-1.7f,-2.25f,0), Quaternion.identity);
            Destroy(this.gameObject);

        }else if(gameObject.transform.position.x== -0.66f)
        {
            Instantiate(instantiated, new Vector3(-0.66f,-2.25f,0), Quaternion.identity);
            Destroy(this.gameObject);

        }else if(gameObject.transform.position.x== 0.38f)
        {
            Instantiate(instantiated, new Vector3(0.38f,-2.25f,0), Quaternion.identity);
            Destroy(this.gameObject);

        }else if(gameObject.transform.position.x== 1.42f)
        {
            Instantiate(instantiated, new Vector3(1.42f,-2.25f,0), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
