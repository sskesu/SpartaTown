using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Participants : MonoBehaviour
{
    [SerializeField] private GameObject participantsUI;
    public void OnClickParticipantBtn()
    {
        participantsUI.SetActive(true);
    }

    public void ExitParticipantBtn()
    {
        participantsUI.SetActive(false);
    }
}
