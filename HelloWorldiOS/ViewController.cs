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

          
            buttonAdd.TouchUpInside+= ButtonAdd_TouchUpInside;
            buttonSubtract.TouchUpInside+= ButtonSubtract_TouchUpInside;
            buttonMultiply.TouchUpInside+= ButtonMultiply_TouchUpInside;
            buttonDivide.TouchUpInside+= ButtonDivide_TouchUpInside;
        
        }

        void ButtonAdd_TouchUpInside(object sender, EventArgs e)
        {
			float num1 = float.Parse(txt1stNum.Text);
			float num2 = float.Parse(txt2ndNum.Text);


            float result = num1 + num2;

            labelAnswer.Text = result.ToString();
		}

        void ButtonSubtract_TouchUpInside(object sender, EventArgs e)
        {
			float num1 = float.Parse(txt1stNum.Text);
			float num2 = float.Parse(txt2ndNum.Text);


			float result = num1 - num2;

			labelAnswer.Text = result.ToString();
        }

        void ButtonMultiply_TouchUpInside(object sender, EventArgs e)
        {
			float num1 = float.Parse(txt1stNum.Text);
			float num2 = float.Parse(txt2ndNum.Text);


			float result = num1 * num2;

			labelAnswer.Text = result.ToString();
        }

        void ButtonDivide_TouchUpInside(object sender, EventArgs e)
        {
			float num1 = float.Parse(txt1stNum.Text);
			float num2 = float.Parse(txt2ndNum.Text);


			float result = num1 / num2;

			labelAnswer.Text = result.ToString();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


