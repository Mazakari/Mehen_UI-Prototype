public class BootstrapState : IState
{
    private const string Initial = "Initial";
    private const string MainMenu = "MainMenu";

    private readonly GameStateMachine _stateMachine;
    private readonly SceneLoader _sceneLoader;

    public BootstrapState(GameStateMachine stateMachine, SceneLoader sceneLoader)
    {
        _stateMachine = stateMachine;
        _sceneLoader = sceneLoader;
    }

    public void Enter()
    {
        //RegisterServices();
        _sceneLoader.Load(Initial, onLoaded: EnterLoadMainMenu);
    }
   
    public void Exit()
    {
    }

    private void RegisterServices()
    {
        // Register required services here
    }

    private void EnterLoadMainMenu() => 
        _stateMachine.Enter<LoadMainMenuState, string>(MainMenu);

}
