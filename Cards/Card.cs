using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    [SerializeField] private CardData data = default;
    [Space]
    [SerializeField] private TMPro.TextMeshProUGUI nameText = null;
    [SerializeField] private TMPro.TextMeshProUGUI labelText = null;
    [SerializeField] private UnityEngine.UI.Image thumbnail = null;

    private void Awake()
    {
        var data = CardsManager.Instance.GetRandomData();
        data.OnUpdate += UpdateVisuals;
        UpdateVisuals(data);
    }

    private void UpdateVisuals(CardData cd)
    {
        nameText.text = cd.Name;
        labelText.text = cd.Description;
        thumbnail.sprite = cd.Thumbnail;
    }
}