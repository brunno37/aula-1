
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class hudcontroller : MonoBehaviour{
    public static hudcontroller Instance;
    public Image HealthBar;
    void Awake(){
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateHp(int hp)
    {
        HealthBar.fillAmount = hp / 100f;
    }
}
