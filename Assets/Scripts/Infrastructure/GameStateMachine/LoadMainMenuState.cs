
using System.Collections.Generic;
using UnityEngine;

public class LoadMainMenuState : IPayloadedState<string>
{
    private readonly GameStateMachine _gameStateMachine;
    private readonly SceneLoader _sceneLoader;
    private readonly LoadingCurtain _curtain;
    private readonly ShopService _shop;
    private readonly MessageService _messages;

    // PLACEHOLDER for test purpose
    private readonly List<string> _testMessages;


    public LoadMainMenuState(GameStateMachine gameStateMachine, SceneLoader sceneLoader, LoadingCurtain curtain, ShopService shop, MessageService messages)
    {
        _gameStateMachine = gameStateMachine;
        _sceneLoader = sceneLoader;
        _curtain = curtain;
        _shop = shop;
        _messages = messages;

        // PLACEHOLDER for test purpose
        _testMessages = new List<string>();
        for (int i = 0; i < 15; i++)
        {
            _testMessages.Add($"test message {i + 1}");
        }
    }

    public void Enter(string sceneName)
    {
        _curtain.Show();
        _sceneLoader.Load(sceneName, OnLoaded);
    }

    public void Exit() 
    {
        _curtain.Hide(); 
    }

    private void OnLoaded()
    {
        // Instantiate main menu canvas
        GameObject prefab = Resources.Load<GameObject>("UI/MainMenuCanvas");
        GameObject ui =  GameObject.Instantiate(prefab);

        // Init Shop items
        Transform shopContentParent = ui.GetComponentInChildren<ShopContent>(true).transform;
        if (shopContentParent == null) { return; }
        _shop.GenerateShopItems(shopContentParent);

        // Fetch messages
        Transform messageContentParent = ui.GetComponentInChildren<MessageContent>(true).transform;
        if (messageContentParent == null) { return; }

        // PLACEHOLDER for test purpose
        _messages.FetchMessages(_testMessages, messageContentParent);

        _gameStateMachine.Enter<MainMenuState>();
    }
}