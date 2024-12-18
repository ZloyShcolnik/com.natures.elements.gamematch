using System.Collections.Generic;
using Core.PlayerInput;
using Core.UI;
using UnityEngine;

namespace Core
{
    [DefaultExecutionOrder(-10000)]
    public class Entry : MonoBehaviour
    {
        [SerializeField] private List<BaseWindow> _ui;
        [SerializeField] private Canvas _canvas;
        [SerializeField] private GameObject _fieldParent;
        [SerializeField] private GameObject _fieldBg;
        [SerializeField] private Cell _cellReference;
        [SerializeField] private CellAtlas _cellAtlas;
        [SerializeField] private TextAtlas _textAtlas;
        [SerializeField] private LevelScoreConstraints _levelConstraints;
        [SerializeField] private AudioSource _sound;
        [SerializeField] private AudioSource _clickSound;

        private SDHDAQE _sdhdaqe;

        private void Awake()
        {
            _sdhdaqe = GetComponent<SDHDAQE>();

            InstallBindings();
        }

        private void Start()
        {
            //ServiceLocator.Get<InterfaceDispatcher>().Open<MainMenuWindow>();
            Absidiant.facitdetems<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<PrivacyDialogWindow>();
            Absidiant.facitdetems<Logenation>().SetFieldVisibility(false);
        }

        private void InstallBindings()
        {
            Absidiant.Bind<CellAtlas>(_cellAtlas);
            Absidiant.Bind<TextAtlas>(_textAtlas);
            Absidiant.Bind<LevelScoreConstraints>(_levelConstraints);
            Absidiant.Bind<SDHDAQE>(_sdhdaqe);
            Absidiant.Bind<Logenation>(new Logenation(_fieldParent, _cellReference,_fieldBg));
            Absidiant.Bind<PlayerInputLogic>(new PlayerInputLogic());
            Absidiant.Bind<Determinator>(new Determinator());
            Absidiant.Bind<AQRWYE>(new AQRWYE());
            Absidiant.Bind<ASWERHJNDFS>(new ASWERHJNDFS());
            
            var levelLoader = new DFSHDSFASW();
            Absidiant.Bind<DFSHDSFASW>(levelLoader);
            Absidiant.Bind<DFHJDFASAS>(new DFHJDFASAS(levelLoader));
            levelLoader.SetListener(Absidiant.facitdetems<DFHJDFASAS>());
            
            Absidiant.Bind<ASWDFRHG>(new ASWDFRHG(_cellReference));
            Absidiant.Bind<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>(new ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF(_ui, _canvas));
            Absidiant.Bind<SADHDSAFHDFSHD>(new SADHDSAFHDFSHD());
            Absidiant.Bind<DSFZJDSFGJDF>(new DSFZJDSFGJDF());
            Absidiant.Bind<SoundController>(new SoundController(_sound));
            Absidiant.Bind<ClickSoundController>(new ClickSoundController(_clickSound));

            _sdhdaqe.Bind(Absidiant.facitdetems<ASWERHJNDFS>()).AsUpdateListener();
            _sdhdaqe.Bind(Absidiant.facitdetems<PlayerInputLogic>()).AsUpdateListener();
            _sdhdaqe.Bind(Absidiant.facitdetems<DFHJDFASAS>()).AsUpdateListener();
        }
    }
}