using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Gun : MonoBehaviour
{
    [SerializeField] private float _range;
    [SerializeField] private LayerMask _targetLayer;

    private Transform cameraTr;
    private void Start()
    {
        cameraTr = Camera.main.transform;
    }

    public void Fire()
    {
        Ray ray = new(cameraTr.transform.position, cameraTr.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, _range, _targetLayer))
        {
            Debug.Log($"{hit.transform.name} Hit!!");
        }
    }
    
}
