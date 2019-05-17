using UnityEngine;
using UnityEngine.UI;

public class Loader : MonoBehaviour

{
    public CharacterData characterData;
    public Button load;

    void Start()
    {
        load.onClick.AddListener(Loading);
    }


    void Loading()
    {
        Debug.Log("Loading");
        characterData = LoadCharacter(0);
    }
    

    static CharacterData LoadCharacter(int characterSlot)
    {
        CharacterData loadedCharacter = new CharacterData();
        loadedCharacter.health = PlayerPrefs.GetFloat("health_CharacterSlot" + characterSlot);
        loadedCharacter.paints = PlayerPrefs.GetInt("paints_CharacterSlot" + characterSlot);

        return loadedCharacter;
    }
}
