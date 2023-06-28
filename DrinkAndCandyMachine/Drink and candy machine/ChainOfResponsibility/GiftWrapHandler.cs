using DrinkAndCandyMachine.Drink_and_candy_machine;
using DrinkAndCandyMachine.Drink_and_candy_machine.Decorator;
using DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.ProductDecorator;
namespace DrinkAndCandyMachine.ChainOfResponsibility
{
    public class GiftWrapHandler : AbstractHandler
    {
        public GiftWrapHandler()
        {
            this.SetNext(new BagHandler());
        }
        public override Product? Handle(Product request)
        {
            /*var form1 = (Form1)Application.OpenForms["Form1"];

            Button wraped = new();
            wraped.Location = new Point(340, 380);
            wraped.Size = new Size(80, 60);
            wraped.Text = "with gift wrap";

            Button notWraped = new();
            notWraped.Location = new Point(425, 380);
            notWraped.Size = new Size(80, 60);
            notWraped.Text = "with out gift wrap";

            form1.Controls.Add(notWraped);
            form1.Controls.Add(wraped);

            wraped.Click += async (sender, e) =>
            {
                form1.Controls.Remove(wraped);
                form1.Controls.Remove(notWraped);
                form1.mre.Set();
                request = new ProductWithGiftWrap(request);
                base.Handle(request);
                await Task.Run(() =>
                {
                    form1.mre.WaitOne();
                    form1.mre.Reset();
                });
            };
            notWraped.Click += async (sender, e) =>
            {
                form1.Controls.Remove(wraped);
                form1.Controls.Remove(notWraped);
                form1.mre.Set();
                base.Handle(request);
                await Task.Run(() =>
                {
                    form1.mre.WaitOne();
                    form1.mre.Reset();
                });
            };
            return request;*/

            string message = "Do you want a gift wrap?";
            string title = "gift wrap";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                return base.Handle(new ProductWithGiftWrap(request));
            }
            else
            {
                return base.Handle(request);
            }

        }
    }
}