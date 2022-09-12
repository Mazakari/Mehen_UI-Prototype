public class MainMenuState : IState
{
    public MainMenuState(GameStateMachine stateMachine)
    {
    }
    public void Enter()
    {
        // Subscribe game start event to switch to another state
    }

    public void Exit()
    {
        // Unload unnecessary assets here before loading the gameplay loop
    }
}