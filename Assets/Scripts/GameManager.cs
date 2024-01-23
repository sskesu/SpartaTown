using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum CharacterType
{
    Penguin,
    Frog
}

public enum TutorType
{
    Ytutor
}

[System.Serializable]
public class Tutor
{
    public TutorType TutorType;
    public string TutorName;
    public string Interaction;
}

[System.Serializable]
public class Character
{
    public CharacterType CharacterType;
    public Sprite CharacterSprite;
    public RuntimeAnimatorController AnimatorController;
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private TMP_Text npcName;
    [SerializeField] private TMP_Text npcText;
    

    public List<Character> CharacterList = new List<Character>();
    public List<Tutor> TutorList = new List<Tutor>();

    public Animator PlayerAnimator;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetCharacter(CharacterType characterType)
    {
        var character = CharacterList.Find(item => item.CharacterType == characterType);

        PlayerAnimator.runtimeAnimatorController = character.AnimatorController;
    }

    public void SetTutorInteraction(TutorType tutorType)
    {
        var tutor = TutorList.Find(item => item.TutorType == tutorType);

        npcName.text = tutor.TutorName;
        npcText.text = tutor.Interaction;
    }

    
}
