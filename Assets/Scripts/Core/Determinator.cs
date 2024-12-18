using System;
using System.Collections.Generic;
using System.Linq;
using Core.Api;
using Core.PlayerInput;
using Core.UI;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Core
{
    public class Determinator : exemenation
    {
        private readonly PlayerInputLogic fongas;
        private readonly Logenation fargus;
        private bool lerease;

        public Determinator()
        {
            fongas = Absidiant.facitdetems<PlayerInputLogic>();
            fargus = Absidiant.facitdetems<Logenation>();

            fongas.WAERSG += DFGHADS;
            fongas.OnDeselected += DSAFHSADF;

            lerease = true;

            fargus.OnAnimationStateStarted += OnAnimStartHandler;
            fargus.OnAnimationStateEnded += OnAnimEndHandler;
        }

        public void DSFH()
        {
            lerease = true;
        }

        private void OnAnimEndHandler()
        {
            DSFH();
        }

        private void OnAnimStartHandler()
        {
            lerease = false;
        }

        private void DSAFHSADF()
        {
            if (!lerease)
                return;

            fargus.Deselect();
        }

        private void DFGHADS(Cell clicked)
        {
            if (!lerease)
                return;

            fargus.OnCellClicked(clicked);
        }
    }

    public class ASWDFRHG : exemenation
    {
        private const int ADSFH = 5;

        private readonly Cell QWEFGV;
        private readonly List<Cell> _WRQW = new List<Cell>();

        public ASWDFRHG(Cell qwefgv)
        {
            QWEFGV = qwefgv;
            for (int i = 0; i < ADSFH; i++)
            {
                Cell instance = Object.Instantiate(qwefgv);
                instance.gameObject.SetActive(false);

                _WRQW.Add(instance);
            }
        }

        public void DSAFHASDFH(Cell cell)
        {
            cell.Type = CellAtlas.CellType.None;
            cell.gameObject.SetActive(false);
            cell.Position = Vector2Int.one * -10;
        }

        public Cell DFRHDEASS()
        {
            if (_WRQW.Count == 0)
                return Object.Instantiate(QWEFGV);

            Cell instance = _WRQW[0];
            _WRQW.RemoveAt(0);
            instance.gameObject.SetActive(true);

            return instance;
        }
    }

    public class DFSHDSFASW : exemenation
    {
        private readonly Logenation _field;
        private readonly ASWERHJNDFS _aswerhjndfs;
        private readonly AQRWYE _aqrwye;
        private readonly SDHDAQE ____ASDFRHG;
        private DFHJDFASAS _listener;

        public int ASDFH { get; private set; }

        public event Action OnLoad;

        public DFSHDSFASW()
        {
            _field = Absidiant.facitdetems<Logenation>();
            _aswerhjndfs = Absidiant.facitdetems<ASWERHJNDFS>();
            _aqrwye = Absidiant.facitdetems<AQRWYE>();
            ____ASDFRHG = Absidiant.facitdetems<SDHDAQE>();
        }

        public void LoadLevel(int index)
        {
            ASDFH = index;

            _aswerhjndfs.DSAFHAZD();
            ____ASDFRHG.SetPauseState(isPaused: false);
            _field.SetFieldVisibility(isVisible: true);
            _field.OnNewLevel();
            _aswerhjndfs.ADSFHADFH();
            _aqrwye.Reset();
            _listener.Reset();

            OnLoad?.Invoke();
        }

        public void SetListener(DFHJDFASAS listener)
        {
            _listener = listener;
        }
    }

    public class AQRWYE : exemenation
    {
        private const float DFGS = 1.1f;
        private const int DGJMAS = 100;

        private List<TargetScore> ___ASDFGHDFH;
        private int __DAFHSASD;

        public int ASDERQ => __DAFHSASD;
        public List<TargetScore> QW4YBDGF => ___ASDFGHDFH;
        public event Action<int> OnValueChanged;

        public AQRWYE()
        {
            var buff = Absidiant.facitdetems<LevelScoreConstraints>().Map[0].Score;
            ___ASDFGHDFH = new List<TargetScore>();

            for (int i = 0; i < buff.Count; i++)
                ___ASDFGHDFH.Add(new TargetScore() { Key = buff[i].Key, Score = 0 });
        }

        public void OnMatch(int amount)
        {
            int extraCells = 0;

            if (amount > 3)
                extraCells = amount - 3;

            // bool isMatch = _score.Any(score => score.Key == type);

            __DAFHSASD += DGJMAS +
                            Mathf.RoundToInt(extraCells * (DGJMAS * DFGS));

            // if (isMatch)
            // {
            //     //var match = _score.First(score => score.Key == type);
            //     var buff = _score;
            //     _score = new List<TargetScore>();
            //
            //     for (int i = 0; i < buff.Count; i++)
            //     {
            //         if (type == buff[i].Key)
            //         {
            //             _score.Add(new TargetScore() { Key = buff[i].Key, Score = buff[i].Score + amount });
            //
            //             continue;
            //         }
            //
            //         _score.Add(new TargetScore() { Key = buff[i].Key, Score = buff[i].Score });
            //     }
            // }

            OnValueChanged?.Invoke(__DAFHSASD);
        }

        public void ASWERADSGDSAFHDS(CellAtlas.CellType type)
        {
            bool isMatch = ___ASDFGHDFH.Any(score => score.Key == type);
            if (!isMatch)
                return;

            for (int i = 0; i < ___ASDFGHDFH.Count; i++)
            {
                if (type == ___ASDFGHDFH[i].Key)
                {
                    ___ASDFGHDFH[i] = new TargetScore() { Key = type, Score = ___ASDFGHDFH[i].Score + 1 };
                    break;
                }
            }
        }

        public void Reset()
        {
            var buff = Absidiant.facitdetems<LevelScoreConstraints>()
                .Map[Absidiant.facitdetems<DFSHDSFASW>().ASDFH].Score;
            ___ASDFGHDFH = new List<TargetScore>();

            for (int i = 0; i < buff.Count; i++)
                ___ASDFGHDFH.Add(new TargetScore() { Key = buff[i].Key, Score = 0 });

            __DAFHSASD = 0;
            OnValueChanged?.Invoke(__DAFHSASD);
        }
    }

    public class ASWERHJNDFS : IUpdateListener
    {
        private float ____;
        private bool ADFHZ__;

        public int Current => Mathf.RoundToInt(____);

        void IUpdateListener.OnUpdate()
        {
            if (!ADFHZ__)
                return;

            ____ += Time.deltaTime;
        }

        public void DSAFHAZD() => ADFHZ__ = true;
        public void ADSFHDF() => ADFHZ__ = false;
        public void ADSFHADFH() => ____ = 0;
    }

    public class ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF : exemenation
    {
        private readonly List<BaseWindow> _windows;
        private readonly Canvas _canvas;
        private readonly Dictionary<Type, BaseWindow> _onScene = new Dictionary<Type, BaseWindow>();

        public ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF(List<BaseWindow> windows, Canvas canvas)
        {
            _windows = windows;
            _canvas = canvas;
        }

        public T Open<T>() where T : BaseWindow
        {
            if (!_onScene.ContainsKey(typeof(T)))
                _onScene[typeof(T)] = Object.Instantiate(_windows.First(window => window.GetType() == typeof(T)),
                    _canvas.transform);

            _onScene[typeof(T)].gameObject.SetActive(true);

            return _onScene[typeof(T)] as T;
        }

        public T Get<T>() where T : BaseWindow
        {
            if (!_onScene.ContainsKey(typeof(T)))
                _onScene[typeof(T)] = Object.Instantiate(_windows.First(window => window.GetType() == typeof(T)),
                    _canvas.transform);

            return _onScene[typeof(T)] as T;
        }
    }

    public class DFHJDFASAS : IUpdateListener
    {
        private const int TimeConstraintInSeconds = 90;

        private readonly LevelScoreConstraints _constraints;
        private readonly ASWERHJNDFS _aswerhjndfs;
        private bool _isInvoked;
        private readonly DFSHDSFASW _dfshdsfasw;

        public event Action OnGameEnd;

        public DFHJDFASAS(DFSHDSFASW dfshdsfasw)
        {
            Absidiant.facitdetems<AQRWYE>().OnValueChanged += CheckWin;
            _aswerhjndfs = Absidiant.facitdetems<ASWERHJNDFS>();
            _constraints = Absidiant.facitdetems<LevelScoreConstraints>();
            _dfshdsfasw = dfshdsfasw;
        }

        private void CheckWin(int _)
        {
            List<TargetScore> current = Absidiant.facitdetems<AQRWYE>().QW4YBDGF;

            if (!_isInvoked &&
                current[0].Score >= _constraints.Map[_dfshdsfasw.ASDFH].Score[0].Score &&
                current[1].Score >= _constraints.Map[_dfshdsfasw.ASDFH].Score[1].Score &&
                current[2].Score >= _constraints.Map[_dfshdsfasw.ASDFH].Score[2].Score)
            {
                OnGameEnd?.Invoke();
                _isInvoked = true;
                Absidiant.facitdetems<ASWERHJNDFS>().ADSFHDF();
            }
        }

        void IUpdateListener.OnUpdate()
        {
            // if (!_isInvoked && _timer.Current > TimeConstraintInSeconds)
            // {
            //     OnGameEnd?.Invoke();
            //     _isInvoked = true;
            //     ServiceLocator.Get<Timer>().Stop();
            // }
        }

        public void Reset() => _isInvoked = false;
    }

    public class SADHDSAFHDFSHD : exemenation
    {
        private readonly DFHJDFASAS _listener;
        private readonly LevelScoreConstraints _constraints;
        private readonly DFSHDSFASW _level;
        private readonly AQRWYE _aqrwye;

        public enum GameResult
        {
            Win,
            Lose
        }

        public event Action<GameResult> OnGameResult;

        public SADHDSAFHDFSHD()
        {
            _listener = Absidiant.facitdetems<DFHJDFASAS>();
            _constraints = Absidiant.facitdetems<LevelScoreConstraints>();
            _level = Absidiant.facitdetems<DFSHDSFASW>();
            _aqrwye = Absidiant.facitdetems<AQRWYE>();

            _listener.OnGameEnd += GetResult;
        }

        private void GetResult()
        {
            // if (_score.Current < _constraints.Map.First(pair => pair.LevelId.Equals(_level.CurrentLevelIndex)).Score)
            // {
            //     OnGameResult?.Invoke(GameResult.Lose);
            //
            //     return;
            // }

            OnGameResult?.Invoke(GameResult.Win);
        }
    }

    public class DSFZJDSFGJDF : exemenation
    {
        private readonly LevelScoreConstraints _constraints;
        private readonly DFSHDSFASW _loader;
        private readonly SADHDSAFHDFSHD _resolver;
        private readonly ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF _ui;
        private readonly AQRWYE _aqrwye;
        private bool[] _openedLevels;

        public bool[] OpenedLevels => _openedLevels;
        public event Action OnNewlevelOpened;

        public DSFZJDSFGJDF()
        {
            _constraints = Absidiant.facitdetems<LevelScoreConstraints>();
            _loader = Absidiant.facitdetems<DFSHDSFASW>();
            _resolver = Absidiant.facitdetems<SADHDSAFHDFSHD>();
            _ui = Absidiant.facitdetems<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>();
            _aqrwye = Absidiant.facitdetems<AQRWYE>();
            _openedLevels = new bool[_constraints.Map.Count];
            _openedLevels[0] = true;

            _resolver.OnGameResult += TryOpenLevel;
        }

        private void TryOpenLevel(SADHDSAFHDFSHD.GameResult result)
        {
            Absidiant.facitdetems<Logenation>().SetFieldVisibility(false);
            EndGameWindow endWindow = _ui.Open<EndGameWindow>();
            endWindow.SetPrev(_ui.Open<GameWindow>());
            endWindow.SetResult(result);

            if (result == SADHDSAFHDFSHD.GameResult.Win)
            {
                if (_loader.ASDFH + 1 >= _constraints.Map.Count)
                {
                    endWindow.ButtonText = "To level menu";
                    endWindow.Init(SADHDSAFHDFSHD.GameResult.Win, true);
                }
                else
                {
                    endWindow.Init(SADHDSAFHDFSHD.GameResult.Win, false);
                    _openedLevels[_loader.ASDFH + 1] = true;
                    OnNewlevelOpened?.Invoke();
                }

                endWindow.Score = _aqrwye.ASDERQ.ToString();
                return;
            }

            endWindow.Init(SADHDSAFHDFSHD.GameResult.Lose, false);
        }
    }

    public class SoundController : exemenation
    {
        protected readonly AudioSource _source;
        private readonly float _startVolume;

        public float Volume
        {
            get => _source.volume / _startVolume;
            set => _source.volume = value * _startVolume;
        }

        public SoundController(AudioSource source)
        {
            _source = source;
            _startVolume = _source.volume;
        }
    }

    public class ClickSoundController : SoundController
    {
        public ClickSoundController(AudioSource source) : base(source)
        {
        }

        public void Play()
        {
            _source.Play();
        }
    }
}