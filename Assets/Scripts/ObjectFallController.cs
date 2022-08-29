using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFallController : MonoBehaviour
{
    public bool currFall;
    public int cntGroundFrames;

    private Rigidbody _rigidBody;

    public void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        cntGroundFrames=0;
        StopFall();
        SetPosY(50);
    }

    public void OnRockEnter()
    {
        if(currFall==false){
            currFall=true;
            cntGroundFrames=0;
            StartFall();
        }
    }

    public void StartFall()
    {
        _rigidBody.useGravity=true;
    }

    public void StopFall()
    {
        _rigidBody.useGravity=false;
    }

    public void OnPointerExit()
    {
    }


    private void SetPosY(float posY)
    {
        // transform.position.y=posY;
        transform.position = new Vector3(transform.position.x, posY, transform.position.z);
    }

    public void Update()
    {
        if(transform.position.y<25 && _rigidBody.velocity.y==0)
        {
            currFall=false;
            cntGroundFrames+=1;
            if(cntGroundFrames==50){
                cntGroundFrames=0;
                StopFall();
                SetPosY(50);
            }
        }
    }
}
