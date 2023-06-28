
using DrinkAndCandyMachine.Drink_and_candy_machine;
namespace DrinkAndCandyMachine.ChainOfResponsibility;
public class PaymentHandler : AbstractHandler
{  
    //Form1 form1 = (Form1)Application.OpenForms["Form1"];
    public PaymentHandler()
    {
        this.SetNext(new GiftWrapHandler());
    }
    public override Product? Handle(Product request)
    { 
        
       /* TextBox paymentText = new();
        paymentText.Location = new Point(353, 320);
        paymentText.Size = new Size(139, 50);
        paymentText.Text = $"You have to pay {request?.Price}$";
        form1.Controls.Add(paymentText);

        TextBox paymentMassage = new();
        paymentMassage.Location = new Point(353, 350);
        paymentMassage.Size = new Size(90, 50);
        form1.Controls.Add(paymentMassage);
        Button paymentButton = new();
        paymentButton.Location = new Point(450, 349);
        paymentButton.Size = new Size(40, 25);
        paymentButton.Text = "Pay";
        form1.Controls.Add(paymentButton);

        paymentButton.Click += async (sender, e) =>
        {
            form1.mre.Set();
            form1.Controls.Remove(paymentButton);
            form1.Controls.Remove(paymentMassage);
            form1.Controls.Remove(paymentText);
            string value = paymentMassage.Text;
            bool success = int.TryParse(value, out int number);
            if (success)
            {
                if (number >= request?.Price)
                {
                    MessageBox.Show($"You have an excess of {number - request.Price}$");
                    request = base.Handle(request);
                }
                    
                else {
                    MessageBox.Show($"You have to pay {request?.Price - number}$ else");
                    form1.mreFinal.Set();
                    request = null;
                }
            }
            else
            {
                MessageBox.Show($"We need money... 😉");
                form1.mreFinal.Set();
                request = null;
            }
            paymentButton.Enabled = false;
            paymentMassage.Enabled = false;
            paymentText.Enabled = false;

            await Task.Run(() =>
            {
                form1.mre.WaitOne();
                form1.mre.Reset();
                return request;
            });
        };
       return request;*/

        string message = $"You need to pay {request.Price}$, \nDo you want to pay?";
        string title = "Payment";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        DialogResult result = MessageBox.Show(message, title, buttons);
        if (result == DialogResult.Yes)
            return base.Handle(request);
        else return null;
        
    }
    
} 