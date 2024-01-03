using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce=80f,SideForce=200f;
    public float moveSpeed = 8f;
    public float IncreaseSpeedByTime = 0.001f;
    public float maxSpeed = 40f;
    public static float gameScoreFall;
    private float screenCenterX;

    
    void Start()
    {
        screenCenterX = Screen.width / 2f;
    }

    void FixedUpdate()
    {
        if (moveSpeed<maxSpeed)
        {
            moveSpeed += Time.deltaTime*IncreaseSpeedByTime;
        }

        rb.velocity = moveSpeed*transform.forward;

        Move();

        if (rb.position.y <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");

        rb.AddForce(SideForce * Time.deltaTime * horizontal, 0 ,0, ForceMode.VelocityChange);

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

    public void movingLeft () 
    {
        
        rb.AddForce(-SideForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
            
    }
    public void movingRight () 
    {
        rb.AddForce(SideForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
            
    }
}
