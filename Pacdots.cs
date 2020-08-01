using System;
using System.Collections;
using UnityEngine;



public class Pacdots : MonoBehaviour
{
    SpriteRenderer MatPacman;
    SpriteRenderer MatPacdot;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {   
       
        if (collision.gameObject.name == "Pacman") 
        {
            MatPacman = collision.gameObject.GetComponent<SpriteRenderer>();
            MatPacdot = gameObject.GetComponent<SpriteRenderer>();
            
            if (MatPacman.color.g == MatPacdot.color.g)
            {
                Destroy(gameObject);
                
            }
            else
            {
                if (MatPacdot.color.g == 0f)
                {
                    MatPacman.color = new Color(1,0,0,1);
                    Destroy(gameObject);
                }
                if (MatPacdot.color.g == 0.5f)
                {
                    MatPacman.color = new Color(1, 0.5f, 0, 1);
                    Destroy(gameObject);
                }
                if (MatPacdot.color.g == 0.8f)
                {
                    MatPacman.color = new Color(1, 0.8f, 0.8f, 1);
                    Destroy(gameObject);
                }
                if (MatPacdot.color.g == 0.9f)
                {
                    MatPacman.color = new Color(0.5f, 0.9f, 0.8f, 1);
                    Destroy(gameObject);
                }
               
            }
            
        }
    }
}
