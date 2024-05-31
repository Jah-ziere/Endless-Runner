using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCreator : MonoBehaviour
{
    public GameObject PlatformPrefab;
    public Transform ReferencePoint;
    private GameObject lastCreatedPlatform;
    // Start is called before the first frame update
    void Start()
    {
       lastCreatedPlatform = Instantiate(PlatformPrefab, ReferencePoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (lastCreatedPlatform.transform.position.x < 0)
        {
            lastCreatedPlatform = Instantiate(PlatformPrefab, ReferencePoint.position, Quaternion.identity);
        }
        
    }
}
