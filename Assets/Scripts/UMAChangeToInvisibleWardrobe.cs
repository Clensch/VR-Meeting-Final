using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class UMAChangeToInvisibleWardrobe : MonoBehaviour
{
    public DynamicCharacterAvatar avatar;
    public UMAWardrobeRecipe wardrobe;
    private bool created = false;


    private void OnEnable()
    {
        avatar.CharacterCreated.AddListener(Created);
    }

    private void OnDisable()
    {
        avatar.CharacterCreated.RemoveListener(Created);
    }

    private void Update()
    {
        if(created)
        {
            avatar.SetSlot(wardrobe.wardrobeSlot, wardrobe.name);
            avatar.BuildCharacter();
            created = false;
        }
    }

    private void Created(UMAData data)
    {
        created = true;
    }
}
