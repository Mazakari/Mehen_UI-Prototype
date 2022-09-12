using System.Collections.Generic;
using UnityEngine;

public class ShopService
{
    private readonly List<ShopItem_SO> _items_SO;
    private readonly List<GameObject> _items;
    private readonly ShopItem _prefab;


    public ShopService(List<ShopItem_SO> items_SO, ShopItem prefab)
    {
        _items_SO = items_SO;
        _prefab = prefab;

        _items = new List<GameObject>();
    }

    public void AddItem(ShopItem_SO newItemSO, Transform at)
    {
        GameObject obj = GameObject.Instantiate(_prefab.gameObject, at);
        ShopItem newItem = obj.GetComponent<ShopItem>();
        if (newItem == null) { return; }

        newItem.InitItem(newItemSO);
        _items.Add(obj);
        
    }

    public void RemoveItem(GameObject item)
    {
        if (!_items.Contains(item)) { return; }
        _items.Remove(item);
    }

    public void GenerateShopItems(Transform at)
    {
        if (_items_SO == null || _items_SO.Count == 0) { return; }

        _items.Clear();
        for (int i = 0; i < _items_SO.Count; i++)
        {
            AddItem(_items_SO[i], at);
        }
    }
}
