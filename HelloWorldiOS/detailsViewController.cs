using Foundation;
using System;
using UIKit;

namespace HelloWorldiOS
{
    public partial class detailsViewController : UIViewController
    {
        public float num1 = 10f;
        public float num2 = 20;

        public int option = 1;
        public float result = 30f;

        public detailsViewController(IntPtr handle) : base(handle)
        {

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            switch(option){
                case 1: 
                    theRealLabelDetails.Text = num1.ToString() + " + " + num2.ToString() + " = " + result.ToString();
                    break;
                case 2:
                    theRealLabelDetails.Text = num1.ToString() + " - " + num2.ToString() + " = " + result.ToString();
                    break;
                case 3:
                    theRealLabelDetails.Text = num1.ToString() + " * " + num2.ToString() + " = " + result.ToString();
                    break;
                case 4:
                    theRealLabelDetails.Text = num1.ToString() + " / " + num2.ToString() + " = " + result.ToString();
                    break;
                    
            }
        
        }
    }

}




