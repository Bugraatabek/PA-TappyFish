using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpForce = 9f;
    
    Rigidbody2D _rb;
    int angle;
    int maxAngle = 20;
    int minAngle = -30;
    
    private void Awake() 
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start() 
    {
        StartCoroutine(GameLogic());
    }

    private void Jump()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, jumpForce);
        }
    }

    private IEnumerator GameLogic()
    {
        while(true)
        {
            Jump();
            if(_rb.velocity.y > 0)
            {
                if(angle <= maxAngle)
                {
                    angle += 4;
                }
            }
            else if(_rb.velocity.y < -2.5)
            {
                if(angle > minAngle)
                {
                    angle -= 2;
                }
            }
            transform.rotation = Quaternion.Euler(0,0,angle);
            yield return null;
        }
    }


}
