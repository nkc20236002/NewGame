using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetBotton : MonoBehaviour
{
    public string sceneName; // ƒŠƒZƒbƒg‚·‚éƒV[ƒ“–¼

    public void OnclickStartButton()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        // ‘Î‰‚·‚éƒXƒe[ƒW‚ÌƒV[ƒ“
=======
        // ‘Î‰‚·‚éƒXƒe[ƒW‚ÌƒV[ƒ“–¼“ü—Í
>>>>>>> main
=======
        // ‘Î‰‚·‚éƒXƒe[ƒW‚ÌƒV[ƒ“–¼“ü—Í
>>>>>>> e915c8e (9æœˆ10æ—¥ã‚¢ã‚»ãƒƒãƒˆè¿½åŠ )
        SceneManager.LoadScene(sceneName);
    }

    public void finish()
    {
        // ƒV[ƒ“Ø‚è‘Ö‚¦3•b
        Invoke("Call", 0f);
    }

    void Call()
    {
        OnclickStartButton();
    }
}
