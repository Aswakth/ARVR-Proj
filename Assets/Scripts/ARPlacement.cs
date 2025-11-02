using UnityEngine;

// Simple placeholder for AR placement logic.
// Replace raycast code with AR Foundation raycasts after installing AR packages.
public class ARPlacement : MonoBehaviour
{
    public GameObject placeablePrefab;
    private GameObject spawnedObject;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit))
            {
                if (spawnedObject == null)
                    spawnedObject = Instantiate(placeablePrefab, hit.point, Quaternion.identity);
                else
                    spawnedObject.transform.position = hit.point;
            }
        }
    }
}
