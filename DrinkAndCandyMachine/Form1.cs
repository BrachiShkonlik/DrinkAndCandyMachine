
using DrinkAndCandyMachine.Drink_and_candy_machine;
using DrinkAndCandyMachine.Drink_and_candy_machine.Observer;
using DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.ColdDrinkFolder;
using DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.DryProductFolder;
using DrinkAndCandyMachine.Drink_and_candy_machine.ProductFolder.ProductDecorator;

namespace DrinkAndCandyMachine
{  
    public partial class Form1 : Form
    {
        Type type = typeof(object);
        public ManualResetEvent mre = new(false);
        public ManualResetEvent mreFinal = new(false);
        readonly List<Type> hotDrinkTypeList = new();
        public Form1()
        {
            InitializeComponent();
            EnabledAll();
            this.Controls["ChooseProduct"].Enabled = true;
            Drink_and_candy_machine.Observer.TaskScheduler.Instance.ScheduleTask(00, 00, 00,
                () => { Machine.SaveAsFile<Txt>("..\\..\\..\\Reports\\report");});
        }


        private void EnabledAll()
        {
            foreach (Control control in this.Controls)
            {
                this.Controls[control.Name].Enabled = false;
            }
        }
        private static void EnabledList(List<Control> toEnabled)
        {
            toEnabled.ForEach(c => c.Enabled = true);
        }

        #region Buttons:
        private void ChooseProduct_Click(object sender, EventArgs e)
        {

            this.Controls["ChooseProduct"].Enabled = false;
            EnabledList(new List<Control>() { this.Controls["HotDrink"], this.Controls["ColdDrink"], this.Controls["DryProduct"] });

        }

        private void DryProduct_Click(object sender, EventArgs e)
        {

            EnabledAll();
            EnabledList(new List<Control>() { this.Controls["Bisli"], this.Controls["Choclate"], this.Controls["ColdDrink"], this.Controls["HotDrink"] });
        }

        private void HotDrink_Click(object sender, EventArgs e)
        {
            EnabledAll();
            EnabledList(new List<Control>() { this.Controls["Sugar"], this.Controls["Coffee"], this.Controls["ColdDrink"], this.Controls["DryProduct"] });
        }


        private void ColdDrink_Click(object sender, EventArgs e)
        {
            EnabledAll();
            EnabledList(new List<Control>() { this.Controls["Cola"], this.Controls["Juice"], this.Controls["DryProduct"], this.Controls["HotDrink"] });
        }

        private void Sugar_Click(object sender, EventArgs e)
        {
            EnabledList(new List<Control>() { this.Controls["Choose"] });
            type = typeof(HotDrink);
            hotDrinkTypeList.Add(typeof(HotDrinkWithSugar));
        }

        private void Coffee_Click(object sender, EventArgs e)
        {
            EnabledList(new List<Control>() { this.Controls["Choose"] });
            type = typeof(HotDrink);
            hotDrinkTypeList.Add(typeof(HotDrinkWithCoffee));
        }

        private void Bisli_Button(object sender, EventArgs e)
        {
            EnabledList(new List<Control>() { this.Controls["Choose"] });
            type = typeof(Bisli);
        }

        private void Choclate_Button(object sender, EventArgs e)
        {
            EnabledList(new List<Control>() { this.Controls["Choose"] });
            type = typeof(Choclate);
        }

        private void Cola_Button(object sender, EventArgs e)
        {
            EnabledList(new List<Control>() { this.Controls["Choose"] });
            type = typeof(CupOfCola);
        }

        private void Juice_Button(object sender, EventArgs e)
        {
            EnabledList(new List<Control>() { this.Controls["Choose"] });
            type = typeof(CupOfJuice);
        }

        private /*async*/ void Choose_Click(object sender, EventArgs e)
        {
            EnabledAll();
            Machine machine = new();
            Product? p = machine.StartProductmentProcedure(type, hotDrinkTypeList.ToArray());
            /*await Task.Run(() =>
            {
                mre.WaitOne();
                mre.Reset();
            });
            await Task.Run(() =>
            {
                mreFinal.WaitOne();
                mreFinal.Reset();
            });*/
            this.Controls["ChooseProduct"].Enabled = true;
            if (p != null)
                ProductDetails.Text = $"You bought {p.Name}, good bye!.😁";
        }

        private void ProductDetails_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}