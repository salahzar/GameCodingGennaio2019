
using UnityEngine;

// Script di movimento molto semplice che usa le frecce per muoversi lungo gli assi x e z
public class Player : MonoBehaviour
{
    public float speed = 10.0f;
    void Update()
    {
        // freccia in su e in giu' (verticale) associata al movimento di x 
        float translationx =  - Input.GetAxis("Vertical") * speed * Time.deltaTime;
        // freccia a sinistra destra (orizzontale) associata al movimento z
        float translationz = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        // se premo spazio aumento la y che e' l'altezza
        float translationy = (Input.GetAxis("Jump") > 0) ? 0.3f : 0;
        
        transform.Translate(translationx, translationy, translationz);
    }
}
