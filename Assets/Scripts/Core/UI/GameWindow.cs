using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Core.UI
{
    public class GameWindow : BaseWindow
    {
        [SerializeField] private Button _pauseButton;
        [SerializeField] private Button _settingsButton;
        [SerializeField] private Button _rulesButton;
        [SerializeField] private TMP_Text _scoreText;
        [SerializeField] private TMP_Text _timeText;
        [SerializeField] private TMP_Text _levelText;
        [SerializeField] private TMP_Text _target0;
        [SerializeField] private TMP_Text _target1;
        [SerializeField] private TMP_Text _target2;
        [SerializeField] private Image _target0Image;
        [SerializeField] private Image _target1Image;
        [SerializeField] private Image _target2Image;

        private AQRWYE _aqrwye;
        private ASWERHJNDFS _aswerhjndfs;
        private LevelScoreConstraints _constraints;
        private DFSHDSFASW _level;
        private bool _isPaused;

        public bool IsPaused
        {
            get => _isPaused;
            private set
            {
                Absidiant.facitdetems<SDHDAQE>().SetPauseState(isPaused: value);
                _isPaused = value;
            }
        }

        public int LevelText
        {
            set
            {
                if (_levelText != null) _levelText.text = $"level {value}";
            }
        }

        public float Time
        {
            set
            {
                int minutes = (int)value / 60;
                int seconds = Mathf.Clamp((int)value % 60, 0, 59);

                if (seconds < 10)
                    _timeText.text = $"{minutes}:0{seconds}";
                else
                    _timeText.text = $"{minutes}:{seconds}";
            }
        }

        public int Score
        {
            set
            {
                //int neededScore = _constraints.Map.First(pair => pair.LevelId.Equals(_level.CurrentLevelIndex)).Score;
                _scoreText.text = $"{value}";
            }
        }

        public int Target0
        {
            set
            {
                if (_target0 != null) _target0.text = $"x{Math.Max(0, value)}";
            }
        }

        public int Target1
        {
            set
            {
                if (_target1 != null) _target1.text = $"x{Math.Max(0, value)}";
            }
        }

        public int Target2
        {
            set
            {
                if (_target2 != null) _target2.text = $"x{Math.Max(0, value)}";
            }
        }

        public void Unpause()
        {
            IsPaused = false;
            Absidiant.facitdetems<Logenation>().SetFieldVisibility(true);
        }

        protected override void OnAwake()
        {
            base.OnAwake();
            _settingsButton?.onClick.AddListener(OpenSettings);
            _pauseButton?.onClick.AddListener(Pause);
            _rulesButton?.onClick.AddListener(OpenRules);
            _aqrwye = Absidiant.facitdetems<AQRWYE>();
            _aswerhjndfs = Absidiant.facitdetems<ASWERHJNDFS>();
            _aqrwye.OnValueChanged += SetAqrwye;
            _constraints = Absidiant.facitdetems<LevelScoreConstraints>();
            _level = Absidiant.facitdetems<DFSHDSFASW>();
            Score = 0;

            _level.OnLoad += SetTargets;
            SetTargets();
        }

        private void SetTargets()
        {
            var atlas = Absidiant.facitdetems<CellAtlas>();

            Target0 = _constraints.Map[_level.ASDFH].Score[0].Score;
            Target1 = _constraints.Map[_level.ASDFH].Score[1].Score;
            Target2 = _constraints.Map[_level.ASDFH].Score[2].Score;

            if (_target0Image != null)
                _target0Image.sprite = atlas.Atlas
                    .First(cell => cell.TypeId == _constraints.Map[_level.ASDFH].Score[0].Key).Sprite;
            if (_target1Image != null)
                _target1Image.sprite = atlas.Atlas
                    .First(cell => cell.TypeId == _constraints.Map[_level.ASDFH].Score[1].Key).Sprite;
            if (_target2Image != null)
                _target2Image.sprite = atlas.Atlas
                    .First(cell => cell.TypeId == _constraints.Map[_level.ASDFH].Score[2].Key).Sprite;
        }

        protected override void OnUpdate()
        {
            base.OnUpdate();

            Time = _aswerhjndfs.Current;
        }

        protected override void Close()
        {
            Absidiant.facitdetems<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<LevelMenuWindow>();
            Absidiant.facitdetems<Logenation>().SetFieldVisibility(false);

            gameObject.SetActive(false);
        }

        private void Pause()
        {
            IsPaused = true;

            Absidiant.facitdetems<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<PauseWindow>();
            Absidiant.facitdetems<Logenation>().SetFieldVisibility(false);

            gameObject.SetActive(false);
        }

        private void OpenSettings()
        {
            IsPaused = true;

            Absidiant.facitdetems<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<SettingsWindow>();
            Absidiant.facitdetems<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Get<SettingsWindow>().SetPrev(this);
            Absidiant.facitdetems<Logenation>().SetFieldVisibility(false);

            gameObject.SetActive(false);
        }

        private void OpenRules()
        {
            IsPaused = true;

            var textWindow = Absidiant.facitdetems<ASDFHGADFSHJSFGJFDGXJMDFVGJMCDF>().Open<LongTextWindow>();
            textWindow.Label = Absidiant.facitdetems<TextAtlas>().Map
                .First(text => text.TypeId == TextAtlas.TextType.Rules).Label;
            textWindow.Text = Absidiant.facitdetems<TextAtlas>().Map
                .First(text => text.TypeId == TextAtlas.TextType.Rules).Text;
            textWindow.SetPrevWindow(this);

            Absidiant.facitdetems<Logenation>().SetFieldVisibility(false);
            gameObject.SetActive(false);
        }

        private void SetAqrwye(int val)
        {
            Score = val;
            var curScore = Absidiant.facitdetems<AQRWYE>();

            (TargetScore t0, TargetScore t1, TargetScore t2) targets = (
                _constraints.Map[_level.ASDFH].Score[0],
                _constraints.Map[_level.ASDFH].Score[1],
                _constraints.Map[_level.ASDFH].Score[2]);

            (int t0, int t1, int t2) currentScores = (
                curScore.QW4YBDGF[0].Score,
                curScore.QW4YBDGF[1].Score,
                curScore.QW4YBDGF[2].Score);

            Target0 = targets.t0.Score - currentScores.t0;
            Target1 = targets.t1.Score - currentScores.t1;
            Target2 = targets.t2.Score - currentScores.t2;
        }
    }
}