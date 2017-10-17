using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DICOMetricsApp
{

    /// <summary>
    /// This is the highest abstraction layer. Where we have no clue what the view is like, what controllers are used, we only determine what application logics are called. 
    /// </summary>
    class BusinessLogic
    {
        /// <summary>
        /// This use case assume rating will only be exported when everything is done. 
        /// </summary>
        public void LabelImagesAsync()
        {
            ApplicationLogic LabelImagesApplication = new ApplicationLogic();

            LabelImagesApplication.getImages();
            LabelImagesApplication.getAllImageRatings();
            LabelImagesApplication.exportImageLabel();
        }


        /// <summary>
        /// This use case assume that 
        /// </summary>
        public void LabelImagesSync()
        {
            ApplicationLogic LabelImagesApplication = new ApplicationLogic();

            LabelImagesApplication.getImages();
            LabelImagesApplication.getImageRatingAndOutput();//Simultaneously SYNC!            
        }
    }
}
