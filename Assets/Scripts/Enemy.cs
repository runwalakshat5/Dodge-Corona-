using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed=10f;



    private void FixedUpdate()
    {
            transform.Rotate(0,0,rotationSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.tag=="Player")
      {
        Destroy(collision.gameObject);
        GameManager.instance.GameOver();
      }
      else if(collision.gameObject.tag == "Ground")
      {
        GameManager.instance.IncrementScore();
        Destroy(gameObject);
      }
    }
}
