using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float FowardForce = 2000f;
    public float SideForce = 500f;
    public PlayerMovment playerMovment;
    // Start is called before the first frame update
    void Start()
    {
        // debug log simmilar to Console.WriteLine but displays messige on unity's console
        //Debug.Log("Labas");
    }

    // Update is called once per frame ( better used fixedUpdate)
    void FixedUpdate()
    {
        // Time delta makes sure that your system's fps dosent give you advantige or disatvantige in speed
        rigidBody.AddForce( 0, 0, FowardForce * Time.deltaTime);
        if (Input.GetKey("a"))
            rigidBody.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey("d"))
            rigidBody.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (rigidBody.position.y < -1f)
        {
            playerMovment.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
