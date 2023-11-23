using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Card Data")]
public class CardData : ScriptableObject
{
    [field: SerializeField]
    public string Name { get; private set; }

    [field: SerializeField, TextArea()]
    public string Description { get; private set; }

    [field: SerializeField] public Sprite Thumbnail { get; private set; }

    public System.Action<CardData> OnUpdate = (cd) => { Debug.Log(cd.Name); };

    public void UpdateName(string newName)
    {
        Name = newName;
        OnUpdate.Invoke(this);
    }
}
