using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;

    private float forwardInput;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public string inputID;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled=!mainCamera.enabled;
            hoodCamera.enabled=!hoodCamera.enabled;
        }
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput=Input.GetAxis("Vertical" + inputID);
        transform.Translate(Vector3.forward*Time.deltaTime * speed*forwardInput);
        transform.Rotate(Vector3.up,Time.deltaTime*turnSpeed*horizontalInput);
        //transform.Translate(Vector3.right * Time.deltaTime*turnSpeed*horizontalInput);
    }
}
