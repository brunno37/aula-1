using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    
    void Start()
    {
        var test = 10;
    }

    
    void Update()
    {
        
    }

    public void Interact(){
        Debug.Log("Player interagiu com o coletável");
        Destroy(gameObject);
    }
    
}
