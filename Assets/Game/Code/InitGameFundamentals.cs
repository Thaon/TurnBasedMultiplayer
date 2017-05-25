using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGameFundamentals : MonoBehaviour {

    #region member variables

    #endregion

    public void Init ()
    {
	    if (!FindObjectOfType<PersistentData>())
        {
            PhotonNetwork.Instantiate("PersistentDataGO", transform.position, Quaternion.identity, 0);
        }	
	}
}
