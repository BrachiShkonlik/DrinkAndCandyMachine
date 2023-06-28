
using DrinkAndCandyMachine.Drink_and_candy_machine;
using DrinkAndCandyMachine.Drink_and_candy_machine.Decorator;
namespace DrinkAndCandyMachine.ChainOfResponsibility
{
    public class BagHandler : AbstractHandler
    {
        public override Product? Handle(Product request)
        {
            /*var form1 = (Form1)Application.OpenForms["Form1"];

            Button bag = new();
            bag.Location = new Point(340, 380);
            bag.Size = new Size(80, 60);
            bag.Text = "with bag";
            

            Button notBag = new();
            notBag.Location = new Point(425, 380);
            notBag.Size = new Size(80, 60);
            notBag.Text = "with out bag";

            form1.Controls.Add(bag);
            form1.Controls.Add(notBag);

            bag.Click += (sender, e) =>
            {
                form1.Controls.Remove(bag);
                form1.Controls.Remove(notBag);
                form1.mre.Set();
                request = new ProductWithGiftWrap(request);
                base.Handle(request);
                form1.mreFinal.Set();
            };

            
            notBag.Click += (sender, e) =>
            {
                form1.Controls.Remove(bag);
                form1.Controls.Remove(notBag);
                form1.mre.Set();
                base.Handle(request);
                form1.mreFinal.Set();
            };

            return request;*/

            string message = "Do you want a bag?";
            string title = "bag";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)           
                return base.Handle(new ProductWithBag(request)); 
            else return base.Handle(request);
        }
    }
}
