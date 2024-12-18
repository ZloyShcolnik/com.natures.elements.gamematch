﻿using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Core.UI
{
    public class SettingsWindow : BaseWindow
    {
        // [SerializeField] private Button _soundButton;
        // [SerializeField] private Button _musicButton;
        [SerializeField] private Button _musicOffButton;
        [SerializeField] private Button _musicOnButton;
        [SerializeField] private Button _soundOffButton;
        [SerializeField] private Button _soundOnButton;
        // [SerializeField] private Slider _musicSlider;

        // [SerializeField] private Image _soundButtonImage;
        // [SerializeField] private Sprite _unmutedSprite;
        // [SerializeField] private Sprite _mutedSprite;

        private bool _isMusicMuted;
        private bool _isSoundMuted;
        private float _prevVolume;
        private BaseWindow _prev;

        private bool IsMuted => фы23ева.фвыйцуРУИ<SoundController>().Volume > 0;

        public void SetPrev(BaseWindow prev)
        {
            _prev = prev;
        }

        protected override void OnAwake()
        {
            // _musicButton?.onClick.AddListener(SwitchMusic);
            // _soundButton?.onClick.AddListener(SwitchSound);

            _musicOnButton?.onClick.AddListener(() => SwitchMusic(true));
            _musicOffButton?.onClick.AddListener(() => SwitchMusic(false));
            _soundOnButton?.onClick.AddListener(() => SwitchSound(true));
            _soundOffButton?.onClick.AddListener(() => SwitchSound(false));

            // _musicOffButton?.onClick.AddListener(OffMusic);
            // _musicSlider.onValueChanged.AddListener(SetVolume);
            // _musicSlider.value = ServiceLocator.Get<SoundController>().Volume;
            // _prevVolume = _musicSlider.value;
            // _musicButton?.onClick.AddListener(SwitchMusic);
            // _soundButton?.onClick.AddListener(SwitchSound);
        }

        protected override void Close()
        {
            base.Close();

            _prev.gameObject.SetActive(true);
            if (_prev is GameWindow gameWindow)
            {
                gameWindow.Unpause();
            }
        }

        // private void OffMusic()
        // {
        //     if (_musicSlider.value == 0)
        //         return;
        //
        //     _prevVolume = _musicSlider.value;
        //     ServiceLocator.Get<SoundController>().Volume = 0;
        //     _musicSlider.value = 0;
        // }
        //
        // private void OnMusic()
        // {
        //     if (_musicSlider.value != 0)
        //         return;
        //
        //     ServiceLocator.Get<SoundController>().Volume = _prevVolume;
        //     _musicSlider.value = _prevVolume;
        // }

        private void SetVolume(float value)
        {
            фы23ева.фвыйцуРУИ<SoundController>().Volume = value;
        }

        private void SwitchSound(bool isOn)
        {
            _isSoundMuted = !isOn;

            фы23ева.фвыйцуРУИ<ClickSoundController>().Volume = _isSoundMuted ? 0 : 1;

            // _soundMutedSprite.gameObject.SetActive(_isSoundMuted);
            // _soundButton.image.sprite = _isSoundMuted ? _mutedSprite : _unmutedSprite;
        }

        private void SwitchMusic(bool isOn)
        {
            _isMusicMuted = !isOn;

            фы23ева.фвыйцуРУИ<SoundController>().Volume = _isMusicMuted ? 0 : 1;

            // _musicMutedSprite.gameObject.SetActive(_isMusicMuted);
            // _musicButton.image.sprite = _isMusicMuted ? _mutedSprite : _unmutedSprite;
        }
    }
}