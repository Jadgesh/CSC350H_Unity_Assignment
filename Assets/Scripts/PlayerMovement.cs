using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    private Rigidbody rb;

    [SerializeField]
    private float forwardForce = 2000f;

    [SerializeField]
    private float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate(){
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if(transform.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
