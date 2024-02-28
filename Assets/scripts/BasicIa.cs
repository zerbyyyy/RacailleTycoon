using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicIa : MonoBehaviour
{
       public float speed = 3f;
    public float moveDistance = 25f;

    private bool movingRight = true;
    private Vector3 initialPosition;

    void Start()
    {
        // Enregistrez la position initiale du personnage
        initialPosition = transform.position;
    }

    void Update()
    {
        // Déplacement vers la droite
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            // Vérifiez si le personnage a atteint la distance maximale vers la droite
            if (transform.position.x >= initialPosition.x + moveDistance)
            {
                movingRight = false; // Changez de direction vers la gauche
            }
        }
        else // Déplacement vers la gauche
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            // Vérifiez si le personnage est revenu à sa position initiale
            if (transform.position.x <= initialPosition.x)
            {
                movingRight = true; // Changez de direction vers la droite
            }
        }
    }
}
