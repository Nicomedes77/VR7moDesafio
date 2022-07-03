using UnityEngine;

public class EnemyII : MonoBehaviour
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
        ChequearDistanciaConElJugador();

        //SeguirAlJugador();
        //LookAtPlayerQuat();

    }

    void ChequearDistanciaConElJugador()
    {
        float dist = Vector3.Distance(transform.position,transformJugador.position);
        Debug.Log("distancia contra el enemigo: " + dist); 

        if(dist <= 2)
        {

        }

        else
        {
            LookAt();
            SeguirLerp();            
        }

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
