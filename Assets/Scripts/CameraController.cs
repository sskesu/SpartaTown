using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraSpeed = 50.0f;

    public GameObject player;

    private void FixedUpdate()
    {
        Vector2 direction = player.transform.position - this.transform.position;
        Vector2 moveVector2 = new Vector2 (direction.x * cameraSpeed * Time.deltaTime, direction.y * cameraSpeed * Time.deltaTime);

        this.transform.Translate (moveVector2);
    }
}
