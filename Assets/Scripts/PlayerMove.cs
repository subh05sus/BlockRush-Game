using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce=80f,SideForce=200f;
    public float moveSpeed = 8f;
    public float IncreaseSpeedByTime = 0.001f;
    public float maxSpeed = 40f;
    public static float gameScoreFall;
    public Transform trans;
    public bool moveLeft=false;
    public bool moveRight=false;
    private float screenCenterX;

    
    void Start()
    {
        // Get the x-coordinate of the center of the screen
    
        screenCenterX = Screen.width / 2f;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (moveSpeed<maxSpeed)
        {
            moveSpeed += Time.deltaTime*IncreaseSpeedByTime;
        }
        //added forward force
        // rb.AddForce(0,0,forwardForce * Time.deltaTime);
        rb.velocity = moveSpeed*transform.forward;
        // adding side movements
        if (Input.GetKey("a"))
        {
            movingLeft ();
        }
        if (Input.GetKey("d"))
        {
            movingRight ();
        }

        if (rb.position.y <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


        // Check if the left or right side of the screen is being held
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x < screenCenterX)
            {
                // Call function1() if the left side of the screen is being held
                movingLeft();
            }
            else
            {
                // Call function2() if the right side of the screen is being held
                movingRight();
            }
        }





    }

    public void movingLeft () {
        rb.AddForce(-SideForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
            
    }
    public void movingRight () {
        rb.AddForce(SideForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
            
    }



}
