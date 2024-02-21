using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class BackgroundMusic : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Récupérer le composant AudioSource attaché à ce GameObject
        audioSource = GetComponent<AudioSource>();

        // Vérifier si l'AudioSource est configuré
        if (audioSource != null && audioSource.clip != null)
        {
            // Démarrer la musique de fond
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Audio clip not set or AudioSource component missing.");
        }
    }
}
public class Player : MonoBehaviour
{
    public float walkSpeed = 6;
    Vector2 moveDirection ;
    SpriteRenderer renderer;



    
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }
   
    void Update()
    {
        
        transform.position += new Vector3(moveDirection.x,moveDirection.y,0)*walkSpeed*Time.deltaTime;

    }

    void OnMove(InputValue value){
        moveDirection = value.Get<Vector2>();
        if(moveDirection.x > 0){
            renderer.flipX = false;
        }
        else if(moveDirection.x < 0){
            renderer.flipX = true;
        }
    }

    
}
