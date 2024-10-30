using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;


public class PlayerMove : MonoBehaviour

{
    [SerializeField] Rigidbody player;
    [SerializeField] GameObject DialogueBox;
    [SerializeField] float speed;
    Vector3 PMInput;
    private bool facingUp;
    //variable to enable step audio
    bool playStep;

    public bool isInRange;
    public GameObject InteractableQueue;
    // Update is called once per frame
    void Update()
    {
        PMInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        Move();
        
    }

    public void Move()
    {
        Vector3 move = transform.TransformDirection(PMInput) * speed;
        player.velocity = new Vector3(move.x, player.velocity.y, move.z);
    }


}
