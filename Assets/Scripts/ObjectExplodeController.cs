using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectExplodeController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isExploded,isFinished;
    public int explosionFrameCnt;
    public float expForce;
    public void Start()
    {
        transform.Find("Explosion").gameObject.SetActive(false);
        transform.Find("ExpBox").gameObject.SetActive(true);
        transform.Find("ExpBoxDestruct").gameObject.SetActive(false);
        isExploded=false;
        explosionFrameCnt=0;
        isFinished=false;
        expForce=2600f;
    }

    public void OnExplodeBoxEnter()
    {
        if(isExploded==false){
            isExploded=true;
        }
    }

    public void OnPointerExit()
    {
    }

    public void Update(){
        if(isExploded==true && isFinished==false)
        {
            if(explosionFrameCnt==50){
                ShatterObject();
                isFinished=true;
            }
            else{
                explosionFrameCnt+=1;
            }
        }
    }

    public void ShatterObject(){
        transform.Find("ExpBox").gameObject.SetActive(false);
        transform.Find("Explosion").gameObject.SetActive(true);
        transform.Find("ExpBoxDestruct").gameObject.SetActive(true);

        Collider[] shatteringObjects=Physics.OverlapSphere(transform.position,80);

        foreach(Collider shatteringObject in shatteringObjects){
            Rigidbody rigbd= shatteringObject.GetComponent<Rigidbody>();
            if(rigbd!=null){
                rigbd.AddExplosionForce(expForce,transform.position,40);
            }
        }
    }
}
