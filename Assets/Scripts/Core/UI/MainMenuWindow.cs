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
            var exitWindow = фы23ева.фвыйцуРУИ<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<ExitWindow>();
            exitWindow.SetPrevWindow(this);
            
            CloseWindow();
        }

        private void OpenSettings()
        {
            var settings = фы23ева.фвыйцуРУИ<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<SettingsWindow>();
            settings.SetPrev(this);

            CloseWindow();
        }

        private void OpenPrivacy()
        {
            LongTextWindow textWindow = фы23ева.фвыйцуРУИ<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<LongTextWindow>();
            textWindow.Label = фы23ева.фвыйцуРУИ<TextAtlas>().Map.First(text => text.TypeId == TextAtlas.TextType.Privacy).Label;
            textWindow.Text = фы23ева.фвыйцуРУИ<TextAtlas>().Map.First(text => text.TypeId == TextAtlas.TextType.Privacy).Text;
            textWindow.SetPrevWindow(this);

            CloseWindow();
        }

        private void OpenRules()
        {
            LongTextWindow textWindow = фы23ева.фвыйцуРУИ<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<LongTextWindow>();
            textWindow.Label = фы23ева.фвыйцуРУИ<TextAtlas>().Map.First(text => text.TypeId == TextAtlas.TextType.Rules).Label;
            textWindow.Text = фы23ева.фвыйцуРУИ<TextAtlas>().Map.First(text => text.TypeId == TextAtlas.TextType.Rules).Text;
            textWindow.SetPrevWindow(this);

            CloseWindow();
        }

        private void OpenLevelMenu()
        {
            фы23ева.фвыйцуРУИ<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<LevelMenuWindow>();

            CloseWindow();
        }

        private void CloseWindow() => gameObject.SetActive(false);
    }
}