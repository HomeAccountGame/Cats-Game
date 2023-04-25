using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void moves()
    {
        GameObject put = GameObject.Find("deck");
        float x = put.transform.position.x-1;
        float y = put.transform.position.y;
        Vector3 movementVector = new Vector3(x, y, 1);
        transform.position = movementVector;
    }
    public void movesaway()
    {
        Vector3 movementVector = new Vector3(1000, 1000, 1000);
        transform.position = movementVector;
    }
}
