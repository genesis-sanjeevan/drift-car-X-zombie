using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class car_movement : MonoBehaviour
{

public float MoveSpeed = 50;
public float MaxSpeed = 60;
public float Drag = 0.98f;
public float SteerAngle = 20;
public float Traction = 1;
private float score;
    public TextMeshProUGUI Text;


private Vector3 MoveForce;
void Update()
{

    // Moving
    MoveForce += transform.forward * MoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
    transform.position += MoveForce * Time.deltaTime;

    // Steering
    float steerInput = Input.GetAxis("Horizontal");
    transform.Rotate(Vector3.up * steerInput * MoveForce.magnitude * SteerAngle * Time.deltaTime);

    // Drag and max speed limit
    MoveForce *= Drag;
    MoveForce = Vector3.ClampMagnitude(MoveForce, MaxSpeed);

    // Traction
    Debug.DrawRay(transform.position, MoveForce.normalized * 3);
    Debug.DrawRay(transform.position, transform.forward * 3, Color.blue);
    MoveForce = Vector3.Lerp(MoveForce.normalized, transform.forward, Traction * Time.deltaTime) * MoveForce.magnitude;
}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Coin")
        {
            score += 1;
            print(score);
            Text.text =score.ToString();
            Destroy(collision.collider.gameObject);
        }
    }



}