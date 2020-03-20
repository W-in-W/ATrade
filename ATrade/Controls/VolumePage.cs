using System;
using System.Windows.Forms;

namespace ATrade.Controls
{
    public partial class VolumePage : UserControl
    {
        public void CalculateVolume()
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
            volumeValueLabel.Text = Math.Round(Convert.ToDouble(stopLossValueNumeric.Value) / (Convert.ToDouble(pointsValueNumeric.Value) * multiplier), 2).ToString();

        }
        public VolumePage()
        {
            InitializeComponent();
            BL.UpdateFuturesComboBox(futuresBox);
            BL.linkToVolumePage = this;
        }

        private void pointsValueNumeric_ValueChanged(object sender, EventArgs e)
        {
            CalculateVolume();
        }

        private void stopLossValueNumeric_ValueChanged(object sender, EventArgs e)
        {
            CalculateVolume();
        }

        private void futuresBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateVolume();
        }
    }
}
