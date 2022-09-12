using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _description;
    private int _amount;
    [SerializeField] private TMP_Text _price;

    public void InitItem(ShopItem_SO shopItem_SO)
    {
        _image.sprite = shopItem_SO.Sprite;
        _description.text = shopItem_SO.Description;
        _amount = shopItem_SO.Amount;
        _price.text = shopItem_SO.Price.ToString("F2");
    }
}
