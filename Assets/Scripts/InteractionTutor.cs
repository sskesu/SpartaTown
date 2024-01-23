using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractionTutor : MonoBehaviour
{
    [SerializeField] private GameObject interactionTrigger;
    [SerializeField] private GameObject interaction;
    [SerializeField] private TutorType tutorType;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!interaction.activeSelf)
        {
            interactionTrigger.SetActive(true);
            GameManager.Instance.SetTutorInteraction(tutorType);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        interactionTrigger.SetActive(false);
    }


    
}
