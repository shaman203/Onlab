using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EEG_Marker
{
    class ActionReader
    {
        private String actionFilename;
        private List<EEG_Action> actions;
        private IMarker marker;
        private IActionDisplay display;
        public ActionReader(String actionFilename, IActionDisplay display, IMarker marker)
        {
            this.display = display;
            this.marker = marker;
            if (System.IO.File.Exists(actionFilename))
            {
                this.actionFilename = actionFilename;
            }
            else
            {
                throw new Exception("File not found: " + actionFilename);
            }
            readActionFile();
        }

        private void readActionFile()
        {
            var reader = new StreamReader(File.OpenRead(actionFilename));
            actions = new List<EEG_Action>();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(';');
                if(values.Length == 5)
                actions.Add(new EEG_Action(values[0], Convert.ToInt32(values[1]), Convert.ToInt32(values[2]), Convert.ToInt32(values[3]), Convert.ToInt32(values[4])));
            }
        }


       private void executeAction(EEG_Action action)
       {
            display.setActionText(action.ActionText);
            Thread.Sleep(action.BeforeMarkerDelay);
            display.changeToActive();
            Thread.Sleep(action.AfterMarkerDelay);
            marker.setMarker(action.MarkerCode);
            Thread.Sleep(action.Duration);
        }

       public void executeActions()
       {
           foreach (EEG_Action action in actions)
           {
               executeAction(action);
           }
           display.doneActions();
       }
    }
}
