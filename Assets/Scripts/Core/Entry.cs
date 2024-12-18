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
            ��23���.���������<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<PrivacyDialogWindow>();
            ��23���.���������<����������������>().SetFieldVisibility(false);
        }

        private void InstallBindings()
        {
            ��23���.Bind<CellAtlas>(_cellAtlas);
            ��23���.Bind<TextAtlas>(_textAtlas);
            ��23���.Bind<LevelScoreConstraints>(_levelConstraints);
            ��23���.Bind<SDHDAQE>(_sdhdaqe);
            ��23���.Bind<����������������>(new ����������������(_fieldParent, _cellReference,_fieldBg));
            ��23���.Bind<�������>(new �������());
            ��23���.Bind<��������>(new ��������());
            ��23���.Bind<AQRWYE>(new AQRWYE());
            ��23���.Bind<ASWERHJNDFS>(new ASWERHJNDFS());
            
            var levelLoader = new DFSHDSFASW();
            ��23���.Bind<DFSHDSFASW>(levelLoader);
            ��23���.Bind<DFHJDFASAS>(new DFHJDFASAS(levelLoader));
            levelLoader.SetListener(��23���.���������<DFHJDFASAS>());
            
            ��23���.Bind<ASWDFRHG>(new ASWDFRHG(_cellReference));
            ��23���.Bind<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>(new ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF(_ui, _canvas));
            ��23���.Bind<SADHDSAFHDFSHD>(new SADHDSAFHDFSHD());
            ��23���.Bind<DSFZJDSFGJDF>(new DSFZJDSFGJDF());
            ��23���.Bind<SoundController>(new SoundController(_sound));
            ��23���.Bind<ClickSoundController>(new ClickSoundController(_clickSound));

            _sdhdaqe.Bind(��23���.���������<ASWERHJNDFS>()).AsUpdateListener();
            _sdhdaqe.Bind(��23���.���������<�������>()).AsUpdateListener();
            _sdhdaqe.Bind(��23���.���������<DFHJDFASAS>()).AsUpdateListener();
        }
    }
}