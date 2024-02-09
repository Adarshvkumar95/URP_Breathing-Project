using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;
using Unity.VisualScripting;
using UnityEngine.UI;

public class VideoPlaybackTrigger : MonoBehaviour {
    public VideoPlayer player;

    public static UnityEvent newVideoPlay;
    RawImage img;
    Material origMat;


    private void Awake() {
        //newVideoPlay = new UnityEvent();

        if (newVideoPlay == null) {
            newVideoPlay = new UnityEvent();
        }

        newVideoPlay.AddListener(StopAllVideos);

        img = GetComponent<RawImage>();
        origMat = img.material;

    }

    //public void Awake() {
    //    player = GetComponent<VideoPlayer>(); 
    //}

    private void OnTriggerEnter(Collider other) {
        //Debug.Log("VideoPlaybackTrigger::Trigger");
        if (player.isPlaying) {
            player.Pause();
            img.material = origMat;
        } else {
            //gameObject.BroadcastMessage("StopAllVideos");

            //            Material mat = new Material();// Instantiate(img.material);
            img.material = null;



            VideoPlaybackTrigger.newVideoPlay.Invoke();

            //VideoMonitor.playVideoEvent .Invoke(img.texture.name);
            VideoMonitor.setTextureEvent.Invoke(img.texture);

            player.Play();
        }
    }

    public void StopAllVideos() {
//        Debug.Log("StopAllVideos");

        if (player.isPlaying) {
            player.Pause();
  //          Debug.Log("STOPPING: " + player.clip.name);
            img.material = origMat;

        }


    }



}
