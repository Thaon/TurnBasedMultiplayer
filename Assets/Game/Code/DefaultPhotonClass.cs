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
        if (PhotonNetwork.inRoom)
        {
            if (!photonView.isMine)
            {
                return;
            }

            //this object is under our control from here!

        }   
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            //write vars, serialize them and send them through
        }

        if (stream.isReading)
        {
            //read serialized incoming data, remember: order is important!
        }
    }

    #region RPCs

    [PunRPC]
    public void DoStuff()
    {

    }

    #endregion
}
