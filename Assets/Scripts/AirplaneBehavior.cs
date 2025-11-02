using UnityEngine;
using UnityEngine.SceneManagement; 

public class AirplaneAutoPilot : MonoBehaviour
{
    public Canvas GameMenu;
    public float moveSpeed = 10f; 
    public float climbSpeed = 5f;  
    public float flightSpeed = 15f; 

    public float liftoffDistance = 20f; 

    public string nextScene = "Scene_1";

    private bool isFlying = false; 

    void Update()
    {
        if (!isFlying)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            if (transform.position.z >= liftoffDistance)
            {
                isFlying = true;
                moveSpeed = flightSpeed;
            }
        }
        else
        {
            Vector3 flightDirection = (Vector3.forward * moveSpeed) + (Vector3.up * climbSpeed);

            transform.Translate(flightDirection.normalized * moveSpeed * Time.deltaTime, Space.Self);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            GameMenu.enabled = true;
        }
    }
}