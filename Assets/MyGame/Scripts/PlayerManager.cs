
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float normalSpeed;
    private float rotateSpeed;
    private Rigidbody2D playerRB;
    private Vector2 playerMovement;


   
    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();


        normalSpeed = 5;
        rotateSpeed = 30;

    }

    
   

    private void FixedUpdate()
    {

        float movement = Input.GetAxis("Vertical") * normalSpeed;
        float rotation = Input.GetAxis("Horizontal") * normalSpeed / 2;

        playerRB.velocity = transform.up * movement;
        playerRB.SetRotation(playerRB.rotation - rotation);
    }


   
}