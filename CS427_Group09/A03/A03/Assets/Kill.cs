using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    void Update(){
    }
    void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Player"){
            // collision.gameObject.SendMessage("Dead", F);
            Destroy(collision.gameObject);
        }
    }
}
