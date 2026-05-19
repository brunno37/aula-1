using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // pode ser usado o 'public vector2 positin' como variavel//

    public float Velocidade = 5f;

    public float forcapulo = 5f;

    public bool EstaNoChao = true;

    public Rigidbody2D rb;

    public int health = 100;
    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 direcao = new Vector2(horizontal, 0f);

        transform.Translate(direcao * Time.deltaTime * Velocidade);


        if (Input.GetKeyDown(KeyCode.Space) && EstaNoChao){
            rb.AddForce(Vector2.up * forcapulo, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("chao")){
            EstaNoChao = true;
        }
        else if (collision.CompareTag("void")){
            SceneManager.LoadScene("SampleScene");
        }
        else if (collision.TryGetComponent(out enemycontroller enemy)){
            health -= enemy.Dano;
            hudcontroller.Instance.UpdateHp(health);
        }
        if (health <= 0) {
            //Player morreu
            SceneManager.LoadScene("SampleScene");
        }
        else if (collision.TryGetComponent(out collectable coletavel)) {
            coletavel.Interact();
        }
        else if (collision.TryGetComponent<finish>(out _)){
            SceneManager.LoadScene("WinScene");
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if (collision.CompareTag("chao")){
            EstaNoChao = false;
        }
    }
}