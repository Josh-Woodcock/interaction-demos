using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrefab : MonoBehaviour {

    public GameObject instantiateObject;

    public Vector3 co_ordinates = new Vector3(-0.891f, 1.011731f,-0.477f);

    public void AddObject()
    {
        Instantiate(instantiateObject, co_ordinates, instantiateObject.transform.rotation);
    }
}
