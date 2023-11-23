using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsManager : MonoBehaviour
{
    public static CardsManager CM { get; private set; } = null;
    public static CardsManager Instance { get => CM; private set => CM = value; }


    [SerializeField] private GameObject cardPrefab = null;
    [SerializeField] private Transform cardParent = null;
    [Space]
    [SerializeField] private CardData[] datas = null;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this.gameObject);
    }

    public CardData GetRandomData()
    {
        if (datas == null || datas.Length == 0) return null;
        return datas[Random.Range(0, datas.Length)];
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(cardPrefab, cardParent);
        }
    }

    [ContextMenu("Manipulate Data")]
    private void ManipulateData()
    {
        datas[datas.Length - 1].UpdateName($"<color=blue{Random.Range(0, 1000)}</color>");
    }
}
