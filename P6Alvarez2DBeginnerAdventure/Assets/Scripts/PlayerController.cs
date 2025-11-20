using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControllerTutorialUpdates : MonoBehaviour
{

    public InputAction LeftAction;
    public InputAction MoveAction;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        

        LeftAction.Enable();
        MoveAction.Enable();
      
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
       Vector2 position = (Vector2)transform.position + move * speed * Time.deltaTime;
        transform.position = position;
    }

}