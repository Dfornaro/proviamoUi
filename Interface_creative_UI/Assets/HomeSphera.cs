using UnityEngine;
/*
 05/07/2023 interfaccia grafica di prova
realizzato: 
ambiente chiuso con sfera che se cliccata viene spinta in punti casuali rimbalzando su le pareti
aggiunto Interfaccia UI pulsante e menu impostazioni con relative impostazione su audio e luce ambientale 
 */
public class HomeSphera : MonoBehaviour
{
    public Rigidbody Sfera;           // per applicare una forza fisica di un vettore con valori casuali
    int random;                      // per muovere la sfera in modo casuale

    void Start()
    {
        random = Random.Range(2, 359);

    }


    void OnMouseDown()
    {                
        transform.Rotate(new Vector3(random, random, random) * Time.deltaTime);       // per routare la sfera in modo casuale
        Sfera.AddForce(transform.forward * 5000f);                                    // per spingere in avanti la sfera
        random = Random.Range(2, 359);                                                // per aggiornare il random per muovere la sfera in modo casuale

        /*

        Debug.Log("oggetto con collisore cliccato");
        f1 = Random.Range(1, 4);
        f2 = Random.Range(1, 4);
        f3 = Random.Range(1, 4);
        Debug.Log("random: f1->"+f1+"\tf2:"+f2+"\tf3"+f3);
        
        if (f1 > 2)        {
             Sfera.AddForce(transform.forward * 5000f);

            transform.Rotate(new Vector3(f1, f2, f3) * Time.deltaTime);
        }else if (f1 <= 2)
        {
            Sfera.AddForce(-transform.forward * 5000f);
            transform.Rotate(new Vector3(f1, f2, f3) * Time.deltaTime);
        }else if (f1 == 0){
            Sfera.AddForce(transform.right * 5000f);
            transform.Rotate(new Vector3(f1, f2, f3) * Time.deltaTime);
        }
        
        */


    }
}
