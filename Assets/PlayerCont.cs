using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerCont : MonoBehaviour
{
    public float velocidad = 8f;
    public float fuerzaSalto = 7f;
    
    private Rigidbody2D rb;
    private bool floor = true;

    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        

          
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            floor = true;
            Debug.Log(floor);
        }
    }
}
