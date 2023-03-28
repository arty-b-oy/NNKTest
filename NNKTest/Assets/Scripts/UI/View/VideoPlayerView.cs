using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Zenject;
public class VideoPlayerView : MonoBehaviour
{
    public VideoPlayer _videoPlayer;
    private bool fadeOn = false;
    private bool fadeOff = false;
    private bool videoIsActiv = false;
    [Inject] private ButtonsView buttonsView;
    public VideoPlayerView(Transform transformParent)
    {
        transform.parent = transformParent;
    }
    void Awake()
    {
        _videoPlayer = GetComponent<VideoPlayer>();
        _videoPlayer.targetCamera = FindObjectOfType<CameraTag>().GetComponent<Camera>();
        buttonsView.videoButtonClik += ClikButton;
    }

    private void Update()
    {
        if (fadeOn)
        {
            if (_videoPlayer.targetCameraAlpha < 1)
                _videoPlayer.targetCameraAlpha += Time.deltaTime;
            if (_videoPlayer.targetCameraAlpha >= 1)
                fadeOn = false;

        }
        else
            if (fadeOff)
        {
            if (_videoPlayer.targetCameraAlpha > 0)
                _videoPlayer.targetCameraAlpha -= Time.deltaTime;
            if (_videoPlayer.targetCameraAlpha <= 0)
            {
                _videoPlayer.Stop();
                fadeOff = false;
            }
        }
    }
    private void StartVideo()
    {
        _videoPlayer.Play();
        fadeOn = true;
        fadeOff = false;
    }
    private void StopVideo()
    {
        fadeOn = false;
        fadeOff = true;
    }

    public void ClikButton()
    {
        if (videoIsActiv)
        {
            videoIsActiv = false;
            StopVideo();
        }
        else
        {
            videoIsActiv = true;
            StartVideo();
        }
    }
}
