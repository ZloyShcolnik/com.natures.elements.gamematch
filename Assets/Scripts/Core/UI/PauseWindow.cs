using UnityEngine;
using UnityEngine.UI;

namespace Core.UI
{
    public class PauseWindow : BaseWindow
    {
        [SerializeField] private Button _restartButton;
        [SerializeField] private Button _soundButton;
        [SerializeField] private Image _soundButtonImage;
        [SerializeField] private Button _menuButton;
        [SerializeField] private Sprite _mutedSprite;
        [SerializeField] private Sprite _unmutedSprite;

        private bool _isMuted;

        protected override void OnAwake()
        {
            _restartButton?.onClick.AddListener(Restart);
            _soundButton?.onClick.AddListener(SwitchSound);
            _menuButton?.onClick.AddListener(OpenMenu);
        }

        protected override void Close()
        {
            base.Close();

            CloseAndReturnToGame();
        }

        private void CloseAndReturnToGame()
        {
            gameObject.SetActive(false);
            
            GameWindow gameWindow = Absidiant.фвыйцуРУИ<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<GameWindow>();
            gameWindow.Unpause();
        }

        private void SwitchSound()
        {
            _isMuted = !_isMuted;

            Absidiant.фвыйцуРУИ<SoundController>().Volume = _isMuted ? 0 : 1;

            _soundButtonImage.sprite = _isMuted ? _unmutedSprite : _mutedSprite;
        }

        private void OpenMenu()
        {
            Absidiant.фвыйцуРУИ<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<MainMenuWindow>();
            Absidiant.фвыйцуРУИ<Logenation>().SetFieldVisibility(false);

            gameObject.SetActive(false);
        }

        private void Restart()
        {
            Absidiant.фвыйцуРУИ<Logenation>().ResetField();
            Absidiant.фвыйцуРУИ<ASWERHJNDFS>().ADSFHADFH();
            Absidiant.фвыйцуРУИ<AQRWYE>().Reset();

            CloseAndReturnToGame();
        }
    }
}