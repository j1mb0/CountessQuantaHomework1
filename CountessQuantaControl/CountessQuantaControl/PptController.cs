using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CountessQuantaControl
{
    using PowerPoint = Microsoft.Office.Interop.PowerPoint;
    using Graph = Microsoft.Office.Interop.Graph;
    using System.Runtime.InteropServices;

    public class PptController
    {
        // File path to PPT
        const string PptFileName = "CountessQuantaState.pptx";


        PowerPoint.Application pptApplication;
        PowerPoint.Presentation presentation;
        PowerPoint.Slides slides;
        PowerPoint.Slide slide;

        int slidesCount;
        int slideIndex;
        bool pptActive;


        public PptController()
        {
            pptActive = GetOpenPpt();
        }

        public bool IsPptActive()
        {
            return pptActive;
        }

        public bool GetOpenPpt()
        {
            bool success = false;
            try
            {
                // Get Running PowerPoint Application object 
                pptApplication = Marshal.GetActiveObject("PowerPoint.Application") as PowerPoint.Application;
            }
            catch
            {

            }

            if (pptApplication != null)
            {
                success = true;

                // Get Presentation Object 
                presentation = pptApplication.ActivePresentation;
                // Get Slide collection object 
                slides = presentation.Slides;
                // Get Slide count 
                slidesCount = slides.Count;
                // Get current selected slide  
                try
                {
                    // Get selected slide object in normal view 
                    slide = slides[pptApplication.ActiveWindow.Selection.SlideRange.SlideNumber];
                }
                catch
                {
                    // Get selected slide object in reading view 
                    slide = pptApplication.SlideShowWindows[1].View.Slide;
                }
            }

            return success;
        }

        public void GoToSlide(int slideNumber)
        {
             if(slideNumber <= slidesCount && slideNumber > 0)
             {
                 try
                 {
                     slide = slides[slideNumber];
                     slides[slideNumber].Select();
                 }
                 catch
                 {
                     pptApplication.SlideShowWindows[slideNumber].View.Previous();
                     slide = pptApplication.SlideShowWindows[slideNumber].View.Slide;
                 }
                
             }
        }
    }
}
