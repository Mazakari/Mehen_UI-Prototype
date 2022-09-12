using UnityEngine;

[CreateAssetMenu(fileName ="ShopItem", menuName = "Shop Items", order =1)]
public class ShopItem_SO : ScriptableObject
{
    [SerializeField] private Sprite _sprite;
    public Sprite Sprite { get { return _sprite; } }


    [SerializeField] private string _description;
    public string Description { get { return _description; } }


    [SerializeField] private int _amount;
    public int Amount { get { return _amount; } }


    [SerializeField] private float _price;
    public float Price { get { return _price; } }
}
