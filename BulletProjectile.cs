using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class BulletProjectile : MonoBehaviour
{
    [SerializeField] private TrailRenderer trailRenderer;
    [SerializeField] private Transform bulletHitVfxPrefab;

    private Vector3 targetPosition;
    public void Setup(Vector3 targetPosition)
    { 
        this.targetPosition = targetPosition;
    }

    private void Update()
    {
        Vector3 moveDir = (targetPosition - transform.position).normalized;
        
        float distanceBeforeMoveing = Vector3.Distance(transform.position, targetPosition);

        float moveSpeed = 200f;
        transform.position += moveDir  * moveSpeed * Time.deltaTime;

        float distanceAfterMoving = Vector3.Distance(transform.position, targetPosition);

        if (distanceBeforeMoveing < distanceAfterMoving)
        {
            transform.position = targetPosition;

            trailRenderer.transform.parent = null;

            Destroy(gameObject);
            //Debug.Log("bullet destoryed");
            Instantiate(bulletHitVfxPrefab, targetPosition, Quaternion.identity);
        }
    }
}
