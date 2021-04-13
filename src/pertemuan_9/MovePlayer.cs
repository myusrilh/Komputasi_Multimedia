using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rigidBody;
    [SerializeField] private float _movespeed = 2f;
    [SerializeField] private float _turnspeed = 30f;

    [SerializeField] private float _jumpForce = 200f;
    private bool _shouldJump;
    void Awake() => _rigidBody = GetComponent<Rigidbody>();

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q)) transform.Rotate(Time.deltaTime * _turnspeed * Vector3.down);
        
        if(Input.GetKey(KeyCode.E)) transform.Rotate(Time.deltaTime * _turnspeed * Vector3.up);

        if(Input.GetKey(KeyCode.D)) transform.position += Time.deltaTime * _movespeed * transform.right;

        if(Input.GetKey(KeyCode.A)) transform.position += Time.deltaTime * _movespeed * -transform.right; //negative right give left values

        if(Input.GetKey(KeyCode.W)) transform.position += Time.deltaTime * _movespeed * transform.forward;

        if(Input.GetKey(KeyCode.S)) transform.position += Time.deltaTime * _movespeed * -transform.forward; //negative forward give backward values

        if(_shouldJump == false){
            _shouldJump = Input.GetKeyDown(KeyCode.Space);
        }

    }

    void FixedUpdate(){
        if(_shouldJump){
            _rigidBody.AddForce(_jumpForce * Vector3.up);
            _shouldJump = false;
        }
    }
}
