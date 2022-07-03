using UnityEngine;

public class TestScript : MonoBehaviour
{
    public float speed = 1f;
    public float rotateSpeed = 1f;
    public Transform posEnemigo;
    float weaponDamage = 20f;

/*
    enum TipoArmas 
    {
        M16,
        GLOCK,
        AK47,
        ESCOPETA
    }

    TipoArmas armasActual = TipoArmas.M16;
*/

    void Start()
    {
//        TestMatematicaVectores();
    }


    void Update()
    {
        MovimientoJugador();   
        //ChequearDistancia();    
    }

    void ChequearDistancia()
    {
        float dist = Vector3.Distance(transform.position , posEnemigo.position);
        Debug.Log("distancia contra el enemigo: " + dist);
    }
/*
    void SetWeaponDamage(TipoArmas _armas)
    {
        switch(_armas)
        {
            case TipoArmas.M16:
            
                weaponDamage = 40;
                break;
            

            case TipoArmas.GLOCK:
            
                weaponDamage = 30;
                break;
            

            case TipoArmas.AK47:
            
                weaponDamage = 50;
                break;
            

            case TipoArmas.ESCOPETA:
            
                weaponDamage = 60;
                break;
            

            default: break;
        }
        
    }
*/
    void MovimientoJugador()
    {
        /*
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Has presionado la tecla espacio");
            transform.Translate(new Vector3(0,0,0.1f));
        }
        */
/*
        // metodo de mover jugador sin rotacion sobre si mismo

        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hor,0,ver) * speed * Time.deltaTime);
*/

        //metodo de mover jugador con rotacion sobre si mismo

        float ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0,0,ver) * speed * Time.deltaTime);
        float hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(0,hor,0) * rotateSpeed * Time.deltaTime);
    }

    void TestMatematicaVectores()
    {
        Vector3 vectorUno = new Vector3(1,1,1);
        Vector3 vectorDos = new Vector3(0,5,2);

        Vector3 resultado = vectorUno + vectorDos;
        Debug.Log("el vector resultado es: " + resultado);
        Debug.Log("la magnitud del vector resultado es: " + resultado.magnitude);
        Debug.Log("el vector normalizado es: " + resultado.normalized);
    }
}
