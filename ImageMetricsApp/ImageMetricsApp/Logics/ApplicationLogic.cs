using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageMetricsApp
{

    /// <summary>
    /// Application logic must NOT know how to manipulate the forms, UIS. Those are the responsibility of many many different controllers
    /// Application logic layer is to implement business logic in more concrete steps but not so concrete that it gets dirty with the actual control manipulation process. 
    /// Also known as USERCASE
    /// </summary>
    class ApplicationLogic //aka USE CASE
    {
        private string DataSource = "Example.csv";

        //Primary Data variables. 
        private string CurrentImage; //current image
        private List<string> ImageS; //current list of Images
        private List<int> ImageSLabelS; //current list of image labels
        private string Destination; //Where data goes to die. 

        /// <summary>
        /// Constructor
        /// </summary>
        public ApplicationLogic()
        {

        }

        /// <summary>
        /// This obtains the image list from somewhere. 
        /// </summary>
        public void getImages()
        {

            CTL_List_Images ImageListController = new CTL_List_Images(DataSource);
            ImageS = ImageListController.GetList();
        }

        public void getAllImageRatings()
        {
            foreach (var Image in ImageS)
            {
                displayImage();
                waitForInput();
                updateImageLabel();
            }
            exportImageLabel();
        }

        public void outputRatings()
        {
            exportImageLabel();
        }

        public void getImageRatingAndOutput()
        {
            foreach (var Image in ImageS)
            {
                displayImage();
                waitForInput();
                updateImageLabel();
                exportImageLabel();
            }
        }

        /// <summary>
        /// This display the image somewhere
        /// </summary>
        public void displayImage()
        {
            //Get image via a controller. 
            CTL_Display_Image ImageController = new CTL_Display_Image();

            //Display image via a controller
            ImageController.SetDisplay(CurrentImage);

        }

        /// <summary>
        /// 
        /// </summary>
        public void waitForInput() { }

        /// <summary>
        /// This save the image label somewhere
        /// </summary>
        public void updateImageLabel()
        {

            //Find the appropriate controller
            //Button InputReader = (Button)MainPage.FindFocusedOne();


            //Use Controller_Input to extract information 
            //CTL_Input_Numeric NullClicked = new CTL_Input_Numeric((Xamarin.Forms.Button)InputReader);           
            //Obtain rating from interface via controller           

            //Record it in the latest label list via the controller. 
            CTL_List_Labels ImageLabelUpdater = new CTL_List_Labels(ImageSLabelS);
            ImageLabelUpdater.Update(CurrentImage); //This will determine the score and then update it in the data model. 

        }

        public void exportImageLabel()
        {
            CTL_Output_Remote OutputController = new CTL_Output_Remote();
            OutputController.Send(Destination, ImageSLabelS);
        }

    }
}
