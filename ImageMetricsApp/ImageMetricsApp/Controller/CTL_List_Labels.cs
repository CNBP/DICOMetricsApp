using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMetricsApp
{
    class CTL_List_Labels : INT_List<int>
    {

        //Interface Methods
        public List<int> GetList()
        {
            throw new NotImplementedException();
        }

        public CTL_List_Labels(List<int> Labels)
        {
            //Initialize the label list based on the number of images that exist. 
        }

        //Proprietary Method:
        public void Update(string index)
        {
            //Find the index
            //Todo: Get score, set score to the 

            //Update score in the index
        }
    }
}
