using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerModel : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private AudioClip jumpSound;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 dir, float moveSpeed)
    {
        Vector3 movement = dir * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }

    public void Jump(float jumpForce)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        SoundManager.Instance.playSound(jumpSound);
    }

    public void Attack()
    {
        // ataco
    }
}
