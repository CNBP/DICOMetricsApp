using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImageMetricsApp
{
    class CTL_List_Images : INT_List<String>
    {
        private List<string> StringList;
        private string URL;

        public CTL_List_Images(string url)
        {
            URL = url ?? throw new ArgumentNullException(nameof(url));
        }

        //Interface Methods
        public List<String> GetList()
        {
            if (URL.ToLower().Contains(".csv"))
            {
                StringList = obtainCSVList(URL);
            }
            else if (URL.ToLower().Contains(".xlsx"))
            {
                StringList = obtainExcelList(URL);
            }
            else if (URL.ToLower().Contains("http"))
            {
                StringList = obtainWWWList(URL);
            }
            else throw new NotImplementedException();

            return StringList;
        }

        //Non-Interface Methods

        private List<string> obtainCSVList(string Source)
        {




            return StringList;
        }

        private List<string> obtainExcelList(string Source)
        {

            return StringList;
        }
        private List<string> obtainWWWList(string Source)
        {
            return StringList;
        }
    }
}
