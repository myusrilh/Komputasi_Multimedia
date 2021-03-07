using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBlock : MonoBehaviour
{
    private Animator animatorController;
    // Start is called before the first frame update
    void Start()
    {
        animatorController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.CompareTag("Player")) 
        animatorController.SetTrigger("Fall");
    }
}
