using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class plataforma : MonoBehaviour{
    public Vector2 PosicaoFinal;
    public Vector2 PosicaoInicial;

    public Vector2 Alvo;

    private void Awake()
    {
        Alvo = PosicaoFinal;  
    }

    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update(){
        if (Vector2.Distance(transform.position, Alvo)<0.1f){
            if (Alvo == PosicaoFinal){
                Alvo = PosicaoInicial;
            }
            else{
                Alvo = PosicaoFinal;
            }
            
        }

        transform.position = Vector2.MoveTowards(transform.position, Alvo, Time.deltaTime * 3f);
    }

}
