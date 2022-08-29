using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class FrogMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        #region Input Physcis Movement 
        
        float limitX = Mathf.Clamp(_rigidbody.position.x, -4f, 4f);
        float limitY = Mathf.Clamp(_rigidbody.position.y, -4f, 4f);
        
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            _rigidbody.MovePosition(new Vector2(limitX + Vector2.right.x, _rigidbody.position.y));
        
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            _rigidbody.MovePosition(new Vector2(limitX + Vector2.left.x, _rigidbody.position.y));      
        
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            _rigidbody.MovePosition(new Vector2(_rigidbody.position.x, limitY + Vector2.up.y));    
        
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            _rigidbody.MovePosition(new Vector2(_rigidbody.position.x, limitY + Vector2.down.y));
        
        if(Input.GetMouseButtonDown(0))
            _rigidbody.MovePosition(_rigidbody.position + Vector2.up);
        
        #endregion 
    }
}
