using Assets.scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    //https://assetstore.unity.com/packages/tools/input-management/joystick-pack-107631 [Fenerax Studios] 
    public FloatingJoystick variableJoystick;
    public float movementSpeed = 1f;
    //https://github.com/UnityTechnologies/2D_IsoTilemaps
    IsometricoRenderer isoRenderer;
    Rigidbody2D rbody;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        isoRenderer = GetComponentInChildren<IsometricoRenderer>();
    }

    void FixedUpdate()
    {
        Vector2 currentPos = rbody.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 inputVector = new Vector2(variableJoystick.Horizontal, variableJoystick.Vertical);
        inputVector = Vector2.ClampMagnitude(inputVector, 1);
        Vector2 movement = inputVector * movementSpeed;
        Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
        isoRenderer.SetDirection(movement);
        rbody.MovePosition(newPos);
    }
}
