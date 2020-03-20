using System;
using System.Windows.Forms;
using System.Globalization;

namespace ATrade.Controls
{
    public partial class ProfitPage : UserControl
    {
        public void CalculateProfit()
        {
            double multiplier = 0;
            switch (futuresBox.Text)
            {
                case "RI":
                    multiplier = Convert.ToDouble(BL.USDCourse) * 0.02;
                    break;
                case "GD":
                case "PT":
                case "PD":
                    multiplier = Convert.ToDouble(BL.USDCourse);
                    break;
                case "BR":
                case "SV":
                case "CL":
                    multiplier = Convert.ToDouble(BL.USDCourse) * 10;
                    break;
                case "NG":
                    multiplier = Convert.ToDouble(BL.USDCourse) * 100;
                    break;
                case "ED":
                case "AU":
                case "GU":
                    multiplier = Convert.ToDouble(BL.USDCourse) * 1000;
                    break;
                case "JP":
                    multiplier = Convert.ToDouble(BL.JPYCourse) * 1000;
                    break;
                case "CF":
                    multiplier = Convert.ToDouble(BL.CHFCourse) * 1000;
                    break;
                case "CA":
                    multiplier = Convert.ToDouble(BL.CADCourse) * 1000;
                    break;
                case "MM":
                    multiplier = 10;
                    break;
                default:
                    multiplier = 1;
                    break;
            }

            resultValueLabel.Text = Math.Round((Convert.ToDouble(pointsValueNumeric.Value * volumeValueNumeric.Value) * multiplier), 2).ToString("C", CultureInfo.GetCultureInfo("ru-RU"));

        }
        public ProfitPage()
        {
            InitializeComponent();
            BL.UpdateFuturesComboBox(futuresBox);
            BL.linkToProfitPage = this;
        }

        private void futuresBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void pointsValueNumeric_ValueChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void volumeValueNumeric_ValueChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }
    }
}
