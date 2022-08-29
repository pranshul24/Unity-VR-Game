using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorController : MonoBehaviour
{
    public Material startMaterial;
    public Material focusedMaterial;
    private Renderer _houseRenderer;

    public void Start()
    {
        _houseRenderer=transform.Find("HouseObj").gameObject.GetComponent<Renderer>();
        _houseRenderer.material=startMaterial;
    }

    public void OnHouseEnter()
    {
        _houseRenderer.material=focusedMaterial;
    }

    public void OnPointerExit()
    {
        _houseRenderer.material=startMaterial;
    }
}
