using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    private MoveCommands Move = new MoveCommands();
    void Update(){
        if(Input.GetMouseButtonDown(0)){
            Move.Move();
        }
    }
}

public class MoveCommands{
    public Vector3 vector = new Vector3(0,0,0);

    public void Move(){
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            transform.position += new Vector3(0,1,0);
            //transform.Translate(new Vector3(0,1,0)); //= vector + new Vector3(0,1,0);
        }

        if(Input.GetKeyDown(KeyCode.DownArrow)){
            transform.position += new Vector3(0,-1,0);
            //transform.Translate(new Vector3(0,-1,0)); //= vector + new Vector3(0,-1,0);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.position += new Vector3(1,0,0);
            //transform.Translate(new Vector3(1,0,0)); //= vector + new Vector3(1,0,0);
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.position += new Vector3(-1,0,0);
            //transform.Translate(new Vector3(-1,0,0)); //= vector + new Vector3(-1,0,0);
        }
    }
}