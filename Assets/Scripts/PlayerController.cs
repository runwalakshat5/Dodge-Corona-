using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    float xInput;
    Vector2 newPosition;

    public float moveSpeed=0.3f;
    public float xPositionLimit=2.3f;
    private void Awake()
    {
      rb=GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
      MovePlayer();
    }
    void MovePlayer()
    {
      //-1 to +1
      xInput=Input.GetAxis("Horizontal");
      newPosition = transform.position;
      newPosition.x+=xInput*moveSpeed;
      newPosition.x=Mathf.Clamp(newPosition.x,-xPositionLimit,xPositionLimit);
      rb.MovePosition(newPosition);


    }
}
