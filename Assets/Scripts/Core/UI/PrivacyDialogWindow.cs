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
            фы23ева.фвыйцуРУИ<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<MainMenuWindow>();

            base.Close();
        }

        private void OpenPrivacy()
        {
            LongTextWindow textWindow = фы23ева.фвыйцуРУИ<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<LongTextWindow>();
            textWindow.Label = фы23ева.фвыйцуРУИ<TextAtlas>().Map.First(text => text.TypeId == TextAtlas.TextType.Privacy).Label;
            textWindow.Text = фы23ева.фвыйцуРУИ<TextAtlas>().Map.First(text => text.TypeId == TextAtlas.TextType.Privacy).Text;
            textWindow.SetPrevWindow(this);

            gameObject.SetActive(false);
        }
    }
}