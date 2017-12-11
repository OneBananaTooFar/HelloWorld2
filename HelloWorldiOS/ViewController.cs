using System;

using UIKit;

namespace HelloWorldiOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
       
            labelAnswer.Text = "Answer Here.";

            float num1 = float.Parse(txt1stNum.Text);
            float num2 = float.Parse(txt2ndNum.Text);

            buttonAdd.TouchUpInside+= ButtonAdd_TouchUpInside;
            buttonSubtract.TouchUpInside+= ButtonSubtract_TouchUpInside;
            buttonMultiply.TouchUpInside+= ButtonMultiply_TouchUpInside;
            buttonDivide.TouchUpInside+= ButtonDivide_TouchUpInside;
        
        }

        void ButtonAdd_TouchUpInside(object sender, EventArgs e)
        {

        }

        void ButtonSubtract_TouchUpInside(object sender, EventArgs e)
        {

        }

        void ButtonMultiply_TouchUpInside(object sender, EventArgs e)
        {

        }

        void ButtonDivide_TouchUpInside(object sender, EventArgs e)
        {

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
