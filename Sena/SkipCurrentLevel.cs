using UnityEngine;

namespace Sena
{
    public class 进入下一个场景 : MonoBehaviour
    {
        private void OnEnable()
        {
            RoR2.Stage.instance.BeginAdvanceStage(RoR2.Run.instance.nextStageScene);
            enabled = false;
        }
    }
}
