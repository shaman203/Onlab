using System;
using System.Collections.Generic;
using System.Text;

namespace EEG_Marker
{
    class EEG_Action
    {
        public string ActionText { get; set; }    
        public int MarkerCode { get; set; }
        public int BeforeMarkerDelay { get; set; }
        public int AfterMarkerDelay { get; set; }
        public int Duration { get; set; }


        public EEG_Action(string ActionText, int MarkerCode, int BeforeMarkerDelay, int AfterMarkerDelay, int Duration)
        {
            this.ActionText = ActionText;
            this.MarkerCode = MarkerCode;
            this.BeforeMarkerDelay = BeforeMarkerDelay;
            this.AfterMarkerDelay = AfterMarkerDelay;
            this.Duration = Duration;
        }

    }
}
