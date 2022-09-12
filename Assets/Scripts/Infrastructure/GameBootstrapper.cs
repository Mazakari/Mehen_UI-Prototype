using System.Collections.Generic;
using UnityEngine;

public class GameBootstrapper : MonoBehaviour, ICoroutineRunner
{
    [SerializeField] private LoadingCurtain _loadingCurtain;
    [SerializeField] private List<ShopItem_SO> _shopItems_SO;
    [SerializeField] private ShopItem _shopItemPrefab;
    [SerializeField] private MessageItem _messageItemPrefab;

    private Game _game;

    private void Awake()
    {
        _game = new Game(this, _loadingCurtain, _shopItems_SO, _shopItemPrefab, _messageItemPrefab);
        _game.StateMachine.Enter<BootstrapState>();
        
        DontDestroyOnLoad(this);
    }
}
