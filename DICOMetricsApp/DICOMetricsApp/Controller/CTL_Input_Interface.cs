using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DICOMetricsApp
{

    /// <summary>
    /// These methods convert the button text to the respective variable types and allow them to be accessed via Received()
    /// </summary>

    class CTL_Input_String : INT_Input<string>
    {
        private string State;

        public CTL_Input_String(Button InputButton)
        {
            State = (string)InputButton.GetValue(Button.TextProperty) ?? throw new ArgumentNullException(nameof(InputButton));
        }

        public string Received()
        {
            return State;
        }
    }

    class CTL_Input_Numeric : INT_Input<int>
    {
        private int state;
        public CTL_Input_Numeric(Button InputButton)
        {
            //Must ensure the button is labelled as number
            state = (int)InputButton.GetValue(Button.TextProperty);
        }
        public int Received()
        {
            return state;
        }
    }

    class CTL_Input_Bool : INT_Input<bool>
    {
        private bool state;
        public CTL_Input_Bool(Button InputButton)
        {
            //Must ensure the button is labeled as number
            state = (bool)InputButton.GetValue(Button.TextProperty);
        }
        public bool Received()
        {
            return state;
        }
    }

}
