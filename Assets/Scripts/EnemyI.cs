using UnityEngine;

public class EnemyI : MonoBehaviour
{
    public Transform transformJugador;  //referencia a la posicion del jugador
//    public GameObject cejasMalas;
//    public GameObject cejasNeutrales;
    public float enemySpeed = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        //ChequearDistanciaConElJugador();
        LookAt();
        //SeguirAlJugador();
        //LookAtPlayerQuat();
        SeguirLerp();
    }

    void ChequearDistanciaConElJugador()
    {
        float dist = Vector3.Distance(transform.position,transformJugador.position);
        Debug.Log("distancia contra el enemigo: " + dist); 
/*
        if(dist <= 5)
        {
            Debug.Log("Poner CEJAS MALAS");
            cejasMalas.SetActive(true);
            cejasNeutrales.SetActive(false);
        }

        else
        {
            Debug.Log("PONER CEJAS NEUTRALES");
            cejasMalas.SetActive(false);
            cejasNeutrales.SetActive(true);            
        }
*/
    }

    void LookAtPlayerQuat()
    {
        Quaternion rot = Quaternion.LookRotation(transformJugador.position - transform.position);
        transform.rotation = rot;
    }

    void LookAt()
    {
        transform.LookAt(transformJugador);
    }

    void SeguirAlJugador()
    {
        transform.position = Vector3.MoveTowards(transform.position, transformJugador.position , enemySpeed * Time.deltaTime);
    }

    void SeguirLerp()
    {
        transform.position = Vector3.Lerp(transform.position, transformJugador.position , enemySpeed * Time.deltaTime);
    }
}
