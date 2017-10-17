using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageMetricsApp
{

    class CTL_FindMainFormControl : INT_Control<Button>
    {
        private MainPage InputForm;

        public CTL_FindMainFormControl(MainPage inputForm)
        {
            //Check to see which button was clicked. 
            InputForm = inputForm;
            //Return reference to that object. 
        }

        public Button GetControl(string ControlName)
        {
            Button ChosenButton = (Button)InputForm.FindFocusedOne();
            return ChosenButton;
        }

        public void SetControl(Button ControlName)
        {
            throw new NotImplementedException();
        }
    }
}
