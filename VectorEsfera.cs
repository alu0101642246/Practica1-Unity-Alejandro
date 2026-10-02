using UnityEngine;

public class VectorEsfera : MonoBehaviour
{
    public Vector3 vector1;
    public Vector3 vector2;
    public float magnitud1, magnitud2, angulo, distancia;
    public int mayor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        magnitud1 = vector1.magnitude;
        magnitud2 = vector2.magnitude;
        angulo = Vector3.Angle(vector1, vector2);
        distancia =  Vector3.Distance(vector1, vector2);
        if (vector1.y > vector2.y) {
            mayor = 1;
        }
        else if (vector1.y < vector2.y)
        {
            mayor = 2;
        }
        else {
            mayor = 0;
        }
        
        string mensaje = "Magnitud del vector 1:  " + magnitud1 + 
                    "     Magnitud del vector 2:  " + magnitud2 +
                    "     Ángulo que forman:  " + angulo +
                    "     Su distancia:  " +  distancia +
                    "     El que está a mayor altura es el:  " +  mayor;
        Debug.Log(mensaje);
    }
}
