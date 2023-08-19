using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    Rigidbody _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (_rb.velocity.magnitude > 0)
            LookDir(_rb.velocity);
    }
    
    //todavia no funciona el lookdir
    void LookDir(Vector3 dir)
    {
        dir.y = 0;
        transform.forward = dir.normalized;
    }
    void OnAttack()
    {
    }
}
