using UnityEngine;

public class Traslacion : MonoBehaviour
{
    //Al ser hijos orbitan con el padre, por lo que este codigo solo es necesario si se quiere una velocidad de traslacion distinta a la de rotacion del padre
    //public
    public Transform center;
    public float traslationSpeed = 10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(center.position, Vector3.up, traslationSpeed * Time.deltaTime);
        Debug.DrawRay(transform.position, Vector3.Cross(Vector3.up, transform.position - center.position).normalized * 3, Color.yellow);
    }
}
