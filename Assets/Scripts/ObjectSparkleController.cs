using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSparkleController : MonoBehaviour
{
    public bool isSparking;
    
    void Start()
    {
        transform.Find("Spark_sys").gameObject.SetActive(false);
        transform.Find("Spark_sys_bottom").gameObject.SetActive(false);
        transform.Find("CylinderTop").gameObject.SetActive(true);
        transform.Find("CylinderBottom").gameObject.SetActive(true);
        isSparking=false;
    }

    public void OnSparkleCylinderEnter()
    {
        if(isSparking==false){
            transform.Find("Spark_sys").gameObject.SetActive(true);
            transform.Find("Spark_sys_bottom").gameObject.SetActive(true);
            isSparking=true;
        }
    }

    public void OnPointerExit()
    {
        if(isSparking==true)
        {
            transform.Find("Spark_sys").gameObject.SetActive(false);
            transform.Find("Spark_sys_bottom").gameObject.SetActive(false);
            isSparking=false;
        }
    }
}
