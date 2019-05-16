using UnityEngine;
using UnityEngine.UI;

public class Saver : MonoBehaviour

{
    public CharacterData characterData;
    public Button yes;
    
    void Start()
    {
        yes.onClick.AddListener(Save);
        
    }

    void Save()
    {
        Debug.Log("Saving");
        SaveCharacter(characterData, 0);
        PlayerPrefs.Save();
    }

    
    static void SaveCharacter(CharacterData data, int characterSlot)
    {
        PlayerPrefs.SetFloat("health_CharacterSlot" + characterSlot, data.health);
        PlayerPrefs.SetInt("paints_CharacterSlot" + characterSlot, data.paints);
        PlayerPrefs.Save();
    }

    
}