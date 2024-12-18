using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Core.UI
{
    public class PrivacyDialogWindow : BaseWindow
    {
        [SerializeField] private Button _privacyButton;

        protected override void OnAwake()
        {
            _privacyButton?.onClick.AddListener(OpenPrivacy);
        }

        protected override void Close()
        {
            Absidiant.фвыйцуРУИ<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<MainMenuWindow>();

            base.Close();
        }

        private void OpenPrivacy()
        {
            LongTextWindow textWindow = Absidiant.фвыйцуРУИ<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<LongTextWindow>();
            textWindow.Label = Absidiant.фвыйцуРУИ<TextAtlas>().Map.First(text => text.TypeId == TextAtlas.TextType.Privacy).Label;
            textWindow.Text = Absidiant.фвыйцуРУИ<TextAtlas>().Map.First(text => text.TypeId == TextAtlas.TextType.Privacy).Text;
            textWindow.SetPrevWindow(this);

            gameObject.SetActive(false);
        }
    }
}