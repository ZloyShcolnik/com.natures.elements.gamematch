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
            פû23וגא.פגûיצףÐÓÈ<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<PrivacyDialogWindow>();
            פû23וגא.פגûיצףÐÓÈ<ûפןגןנפûנגאגûלûג>().SetFieldVisibility(false);
        }

        private void InstallBindings()
        {
            פû23וגא.Bind<CellAtlas>(_cellAtlas);
            פû23וגא.Bind<TextAtlas>(_textAtlas);
            פû23וגא.Bind<LevelScoreConstraints>(_levelConstraints);
            פû23וגא.Bind<SDHDAQE>(_sdhdaqe);
            פû23וגא.Bind<ûפןגןנפûנגאגûלûג>(new ûפןגןנפûנגאגûלûג(_fieldParent, _cellReference,_fieldBg));
            פû23וגא.Bind<אגנûגאנ>(new אגנûגאנ());
            פû23וגא.Bind<גאןןנûגא>(new גאןןנûגא());
            פû23וגא.Bind<AQRWYE>(new AQRWYE());
            פû23וגא.Bind<ASWERHJNDFS>(new ASWERHJNDFS());
            
            var levelLoader = new DFSHDSFASW();
            פû23וגא.Bind<DFSHDSFASW>(levelLoader);
            פû23וגא.Bind<DFHJDFASAS>(new DFHJDFASAS(levelLoader));
            levelLoader.SetListener(פû23וגא.פגûיצףÐÓÈ<DFHJDFASAS>());
            
            פû23וגא.Bind<ASWDFRHG>(new ASWDFRHG(_cellReference));
            פû23וגא.Bind<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>(new ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF(_ui, _canvas));
            פû23וגא.Bind<SADHDSAFHDFSHD>(new SADHDSAFHDFSHD());
            פû23וגא.Bind<DSFZJDSFGJDF>(new DSFZJDSFGJDF());
            פû23וגא.Bind<SoundController>(new SoundController(_sound));
            פû23וגא.Bind<ClickSoundController>(new ClickSoundController(_clickSound));

            _sdhdaqe.Bind(פû23וגא.פגûיצףÐÓÈ<ASWERHJNDFS>()).AsUpdateListener();
            _sdhdaqe.Bind(פû23וגא.פגûיצףÐÓÈ<אגנûגאנ>()).AsUpdateListener();
            _sdhdaqe.Bind(פû23וגא.פגûיצףÐÓÈ<DFHJDFASAS>()).AsUpdateListener();
        }
    }
}