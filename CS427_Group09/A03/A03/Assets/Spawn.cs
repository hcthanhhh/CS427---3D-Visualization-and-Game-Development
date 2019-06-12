using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Player; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("spawn",3,0); 
    
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawn()
    {
        GameObject newPlayer = (GameObject) Instantiate (Player) as GameObject;
        float x = Random.Range(-5,5); 

        newPlayer.transform.position = new Vector2(x,-3);

    }
}
