using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class CarMovement : MonoBehaviour
{
    [Header ("Car Speed Variables")]
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;
    
    private Rigidbody2D _rigidbody;
    private float _carSpeed;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _carSpeed = Random.Range(minSpeed, maxSpeed);
        Destroy(gameObject, 5f);
    }

    private void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y); 
        _rigidbody.MovePosition(_rigidbody.position + forward * (_carSpeed * Time.fixedDeltaTime));
    }
}
