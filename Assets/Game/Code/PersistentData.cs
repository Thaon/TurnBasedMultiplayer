using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;

public class PersistentData : Photon.MonoBehaviour, IPunObservable
{

    #region member variables

    public int m_turn;

    #endregion

    void Start ()
    {
		
	}
	
	void Update ()
    {
        if (!PhotonNetwork.inRoom)
        {
            if (!photonView.isMine)
            {
                return;
            }

            //this object is under our control from here!
            if (Input.GetKeyDown(KeyCode.Space))
            {
                photonView.RPC("SetTurn", PhotonTargets.All, PhotonNetwork.player.ID);
            }
        }
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
    public void SetTurn(int turn)
    {
        m_turn = turn;
        print(m_turn);
    }

    #endregion
}
