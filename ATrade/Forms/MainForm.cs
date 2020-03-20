using System;
using System.Windows.Forms;
using ATrade.Forms;
using System.Threading.Tasks;

namespace ATrade
{
    public partial class MainForm : Form
    {
        public async void UpdateCourseAsync()
        {
            try
            {
                await Task.Run(() => BL.UpdateAllPages());
                await Task.Run(() => BL.UpdateAllCourses());
                courseLabel.Text = BL.USDCourse;
                label4.Text = BL.GetLastUpdateTime(BL.USDCoursePageHTML);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось получить курс, проверьте соединение с интернетом.",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public MainForm()
        {
            InitializeComponent();
            volumePage1.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            UpdateCourseAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateCourseAsync();
            this.ActiveControl = null; // Сбрасываем фокус с кнопки обновления курса (чисто визуальный смысл)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            volumePage1.Hide();
            profitPage1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            profitPage1.Hide();
            volumePage1.Show();
        }

        private void выбратьИнструментыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuturesBox futuresBox = new FuturesBox();
            futuresBox.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ATrade v{BL.programVersion}\n\rАвтор: Айдар Мустафин", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
