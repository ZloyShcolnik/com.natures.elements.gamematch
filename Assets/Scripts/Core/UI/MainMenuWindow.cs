using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Core.UI
{
    public class MainMenuWindow : BaseWindow
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _settingsButton;
        [SerializeField] private Button _rulesButton;
        [SerializeField] private Button _privacyButton;

        protected override void OnAwake()
        {
            _playButton?.onClick.AddListener(OpenLevelMenu);
            _settingsButton?.onClick.AddListener(OpenSettings);
            _rulesButton?.onClick.AddListener(OpenRules);
            _privacyButton?.onClick.AddListener(OpenPrivacy);
        }

        protected override void Close()
        {
            var exitWindow = Absidiant.facitdetems<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<ExitWindow>();
            exitWindow.SetPrevWindow(this);
            
            CloseWindow();
        }

        private void OpenSettings()
        {
            var settings = Absidiant.facitdetems<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<SettingsWindow>();
            settings.SetPrev(this);

            CloseWindow();
        }

        private void OpenPrivacy()
        {
            LongTextWindow textWindow = Absidiant.facitdetems<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<LongTextWindow>();
            textWindow.Label = Absidiant.facitdetems<TextAtlas>().Map.First(text => text.TypeId == TextAtlas.TextType.Privacy).Label;
            textWindow.Text = Absidiant.facitdetems<TextAtlas>().Map.First(text => text.TypeId == TextAtlas.TextType.Privacy).Text;
            textWindow.SetPrevWindow(this);

            CloseWindow();
        }

        private void OpenRules()
        {
            LongTextWindow textWindow = Absidiant.facitdetems<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<LongTextWindow>();
            textWindow.Label = Absidiant.facitdetems<TextAtlas>().Map.First(text => text.TypeId == TextAtlas.TextType.Rules).Label;
            textWindow.Text = Absidiant.facitdetems<TextAtlas>().Map.First(text => text.TypeId == TextAtlas.TextType.Rules).Text;
            textWindow.SetPrevWindow(this);

            CloseWindow();
        }

        private void OpenLevelMenu()
        {
            Absidiant.facitdetems<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<LevelMenuWindow>();

            CloseWindow();
        }

        private void CloseWindow() => gameObject.SetActive(false);
    }
}