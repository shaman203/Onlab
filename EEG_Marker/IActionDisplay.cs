using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EEG_Marker
{
    interface IActionDisplay
    {
        void setActionText(string text);

        void changeToActive();

        void doneActions();
    }
}
