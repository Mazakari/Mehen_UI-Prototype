using System.Collections.Generic;
using UnityEngine;

public class MessageService
{
    private readonly List<GameObject> _messages;
    private readonly MessageItem _prefab;

    public MessageService(MessageItem prefab)
    {
        _prefab = prefab;

        _messages = new List<GameObject>();
    }


    public void AddItem(string newMessage, Transform at)
    {
        GameObject obj = GameObject.Instantiate(_prefab.gameObject, at);
        MessageItem message = obj.GetComponent<MessageItem>();
        if (message == null) { return; }

        message.InitMessage(newMessage);
        _messages.Add(obj);
    }

    public void RemoveItem(GameObject item)
    {
        if (!_messages.Contains(item)) { return; }
        _messages.Remove(item);
    }

    public void FetchMessages(List<string> messagesList, Transform at)
    {
        _messages.Clear();
        for (int i = 0; i < messagesList.Count; i++)
        {
            AddItem(messagesList[i], at);
        }
    }
}