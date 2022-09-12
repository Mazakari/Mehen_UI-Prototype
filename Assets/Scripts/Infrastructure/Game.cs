using System.Collections.Generic;

public class Game
{
    public GameStateMachine StateMachine;
    public ShopService Shop;
    public MessageService Messages;

    public Game(ICoroutineRunner coroutineRunner, 
        LoadingCurtain curtain, 
        List<ShopItem_SO> items, 
        ShopItem shopItemPrefab, 
        MessageItem messageItemPrefab )
    {
        Shop = new ShopService(items, shopItemPrefab);
        Messages = new MessageService(messageItemPrefab);
        StateMachine = new GameStateMachine(new SceneLoader(coroutineRunner), curtain, Shop, Messages);
    }
}
