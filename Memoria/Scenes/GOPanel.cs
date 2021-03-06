using UnityEngine;

namespace Memoria
{
    internal sealed class GOPanel<T> : GOArray<T> where T : GOBase
    {
        public readonly UIPanel Panel;

        public GOPanel(GameObject obj)
            : base(obj)
        {
            Panel = obj.GetExactComponent<UIPanel>();
        }
    }
}