using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShapeController : MonoBehaviour
{
    void Start()
    {
        transform.Find("Cylinder").gameObject.SetActive(true);
        transform.Find("Box").gameObject.SetActive(false);
    }

    public void OnBarellEnter()
    {
        transform.Find("Cylinder").gameObject.SetActive(false);
        transform.Find("Box").gameObject.SetActive(true);
    }

    public void OnPointerExit()
    {
        transform.Find("Cylinder").gameObject.SetActive(true);
        transform.Find("Box").gameObject.SetActive(false);
    }
}
