using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSurfaceHandler : MonoBehaviour
{
    [Header("Surface detection")]
    public LayerMask surfaceLayer;

    Collider2D[] surfaceColliderHit = new Collider2D[10];

    Surface.SurfaceTypes drivingOnSurface = Surface.SurfaceTypes.Road;

    Collider2D carCollider;

    void Awake()
    {
        carCollider = GetComponentInChildren<Collider2D>();
    }

    void Update()
    {
        ContactFilter2D contactFilter2D = new ContactFilter2D();
        contactFilter2D.layerMask = surfaceLayer;
        contactFilter2D.useLayerMask = true;
        contactFilter2D.useTrigger = true;

        int numberOfHits = Physics2D.OverlapCollider(carCollider, contactFilter2D, surfaceCollidersHit);

        float lastSurfaceZValue = -1000;

        for (int i = 0; i < numberOfHits; i++)
        {
            Surface surface = surfaceColliderHit[i].GetComponent<Surface>();

            if (surface.transform.position.z > lastSurfaceZValue)
            {
                dirivngOnSurface = surface.surfaceType;
                lastSurfaceZValue = surface.transform.position.z;
            }
        }
        if (numberOfHits == 0)
            drivingOnSurface = Surface.SurfaceTypes.Road;

            Debug.Log();
    }
}
