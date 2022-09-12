using UnityEngine;
using UnityEngine.UI;

public class MainMenuNavigation : MonoBehaviour
{
    [Header("Shop popup")]
    [SerializeField] private GameObject _shopPopup;
    [SerializeField] private Button _shopBackButton;

    [Header("Options popup")]
    [SerializeField] private GameObject _optionsPopup;
    [SerializeField] private Toggle _musicToggle;
    [SerializeField] private Toggle _soundToggle;
    [SerializeField] private Button _optionsBackButton;

    [Header("Options popup")]
    [SerializeField] private GameObject _messagesPopup;
    [SerializeField] private Button _messagesBackButton;

    [Header("Main menu buttons")]
    [SerializeField] private Button _shopButton;
    [SerializeField] private Button _optionsButton;
    [SerializeField] private Button _messagesButton;
    [SerializeField] private Button _quitButton;

    private void OnEnable()
    {
        InitUi();

        _shopButton.onClick.AddListener(ShowShopPopup);
        _shopBackButton.onClick.AddListener(HideShopPopup);

        _optionsButton.onClick.AddListener(ShowOptionsPopup);
        //_musicToggle.onClick.AddListener();
        //_soundToggle.onClick.AddListener();
        _optionsBackButton.onClick.AddListener(HideOptionsPopup);

        _messagesButton.onClick.AddListener(ShowMessagesPopup);
        _messagesBackButton.onClick.AddListener(HideMessagesPopup);

        _quitButton.onClick.AddListener(QuitGame);
    }

    private void OnDisable()
    {
        _shopButton.onClick.RemoveAllListeners();
        _optionsButton.onClick.RemoveAllListeners();
        _messagesButton.onClick.RemoveAllListeners();


        _shopButton.onClick.RemoveAllListeners(); ;
        _shopBackButton.onClick.RemoveAllListeners(); 

        _optionsButton.onClick.RemoveAllListeners(); 
        //_musicToggle.onClick.RemoveAllListeners();
        //_soundToggle.onClick.RemoveAllListeners();
        _optionsBackButton.onClick.RemoveAllListeners();

        _messagesButton.onClick.RemoveAllListeners();
        _messagesBackButton.onClick.RemoveAllListeners();

        _quitButton.onClick.RemoveAllListeners();
    }

    private void InitUi()
    {
        _shopPopup.SetActive(false);
        _optionsPopup.SetActive(false);
        _messagesPopup.SetActive(false);
    }

    private void ShowShopPopup()
    {
        _shopPopup.SetActive(true);
    }
    private void HideShopPopup()
    {
        _shopPopup.SetActive(false);
    }

    private void ShowOptionsPopup()
    {
        _optionsPopup.SetActive(true);
    }
    private void HideOptionsPopup()
    {
        _optionsPopup.SetActive(false);
    }

    private void ShowMessagesPopup()
    {
        _messagesPopup.SetActive(true);
    }
    private void HideMessagesPopup()
    {
        _messagesPopup.SetActive(false);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
