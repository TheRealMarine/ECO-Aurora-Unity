using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.EventSystems;

namespace Eco.Client.UnityUtils
{
    //A place you can stick breakpoints to see when transforms change.
    public class UITracker : UIBehaviour
    {
        protected override void OnBeforeTransformParentChanged() { base.OnBeforeTransformParentChanged(); }
        protected override void OnRectTransformDimensionsChange() { base.OnRectTransformDimensionsChange(); }
        
    }
}
