using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;

public class DefaultPhotonClass : Photon.MonoBehaviour, IPunObservable
{

    #region member variables



    #endregion

    void Start()
    {

    }

    void Update()
    {
        if (!photonView.isMine || !PhotonNetwork.inRoom)
        {
            return;
        }

        //this object is under our control from here!
            
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {

        }

        if (stream.isReading)
        {

        }
    }

    #region RPCs

    [PunRPC]
    public void DoStuff()
    {

    }

    #endregion
}
