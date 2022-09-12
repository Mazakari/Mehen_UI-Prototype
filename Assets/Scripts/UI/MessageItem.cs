using TMPro;
using UnityEngine;

public class MessageItem : MonoBehaviour
{
    [SerializeField] private TMP_Text _description;

    public void InitMessage(string messageText)
    {
        _description.text = messageText;
    }
}
