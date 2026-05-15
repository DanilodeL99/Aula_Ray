using UnityEngine;

public class RaycastsController : MonoBehaviour
{
    public float distancia = 100f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Mouse1 for: daddy gojo" + hit.collider.name);
                Destroy(hit.collider.gameObject);
            }
        }


 
    }
}