using System;
using System.Linq;
using System.Windows.Forms;
namespace ATrade
{
    public partial class FuturesBox : Form
    {
        // При возможном в будущем добавлении новых фьючерсов в программу, поля Text и Name чекбокса должны совпадать,
        // т.к. в функции UpdateCheckBoxes происходит поиск чекбокса по его имени.

        // В UpdateCheckBoxes мы сравниваем имя сохранённого фьючерса с именем каждого чекбокса
        // и при совпадении меняем состояние Checked на true. Для этого мы предварительно погружаемся
        // в GroupBoxы, которые являются контейнерами для Checkbox элементов.
        public static void UpdateCheckBoxes()
        {
            foreach (var item in Properties.Settings.Default.futuresCollection)
            {
                foreach (GroupBox parent in BL.linkToFuturesBox.Controls.OfType<GroupBox>())
                {
                    foreach (CheckBox child in parent.Controls.OfType<CheckBox>())
                    {
                        if (child.Name == item)
                        {
                            (BL.linkToFuturesBox.Controls[$"{parent.Name}"].Controls[$"{item}"] as CheckBox).Checked = true;
                        }
                    }
                }
            }
        }
        public FuturesBox()
        {
            InitializeComponent();
            BL.linkToFuturesBox = this;
            UpdateCheckBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (GroupBox parent in Controls.OfType<GroupBox>())
            {
                foreach (CheckBox child in parent.Controls.OfType<CheckBox>())
                {
                    child.Checked = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (GroupBox parent in Controls.OfType<GroupBox>())
            {
                foreach (CheckBox child in parent.Controls.OfType<CheckBox>())
                {
                    child.Checked = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BL.UpdateFuturesCollection();
            BL.UpdateFuturesComboBox(BL.linkToProfitPage.Controls["futuresBox"] as ComboBox);
            BL.UpdateFuturesComboBox(BL.linkToVolumePage.Controls["futuresBox"] as ComboBox);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
