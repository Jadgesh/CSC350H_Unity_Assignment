using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerMovement movement;

    private void Start(){
        movement = GetComponent<PlayerMovement>();
    }
    void OnCollisionEnter(Collision other){
        if(other.collider.tag == "Obstacle"){
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
