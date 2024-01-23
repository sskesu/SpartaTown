using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image characterSprite;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TMP_InputField changeInputField;
    [SerializeField] private TMP_Text playerName;
    [SerializeField] private GameObject information;
    [SerializeField] private GameObject selectCharacter;
    [SerializeField] private GameObject changeName;
    [SerializeField] private GameObject interaction;
    [SerializeField] private GameObject interactionTrigger;
    [SerializeField] private TMP_Text participantsName;
    [TextArea] string a_text;

    private CharacterType characterType;
    private bool IsStartMenu = true;

    public void OnClickCharacter()
    {
        selectCharacter.SetActive(true);
    }

    
    public void OnClickNameChange()
    {
        changeName.SetActive(true);
    }

    public void OnClickSelectCharacter(int index) 
    {
        characterType = (CharacterType)index;
        var character = GameManager.Instance.CharacterList.Find(item=> item.CharacterType == characterType);

        characterSprite.sprite = character.CharacterSprite;
        characterSprite.SetNativeSize();

        selectCharacter.SetActive(false);

        if (!IsStartMenu)
        {
            GameManager.Instance.SetCharacter(characterType);
        }
    }

    public void OnClickJoin()
    {
        if (inputField.text.Length < 2 || inputField.text.Length > 10)
        {
            return;
        }

        playerName.text = inputField.text;

        GameManager.Instance.SetCharacter(characterType);

        SetParticipantsName();
        information.SetActive(false);
        IsStartMenu = false;
    }

    public void OnClickChange()
    {
        if (changeInputField.text.Length < 2 || changeInputField.text.Length > 10)
        {
            return;
        }

        playerName.text = changeInputField.text;
        SetParticipantsName();
        changeName.SetActive(false);
    }

    public void OnClickRingTutor()
    {
        interactionTrigger.SetActive(false);
        interaction.SetActive(true);
    }

    public void ExitInteraction()
    {
        interaction.SetActive(false);
    }

    private void SetParticipantsName()
    {
        participantsName.text = "";
        foreach (var item in GameManager.Instance.TutorList)
        {
            participantsName.text += item.TutorName;
            participantsName.text += "\n";
        }
        participantsName.text += playerName.text;
    }
}
