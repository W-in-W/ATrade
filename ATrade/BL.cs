using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATrade
{
    class BL
    {
        public static readonly string programVersion = "1.0.0";

        public static FuturesBox linkToFuturesBox;
        public static Controls.ProfitPage linkToProfitPage;
        public static Controls.VolumePage linkToVolumePage;

        public static string USDCoursePageHTML;
        public static string JPYCoursePageHTML;
        public static string CHFCoursePageHTML;
        public static string CADCoursePageHTML;

        private static readonly string USDCoursePageLink = "https://www.moex.com/ru/derivatives/currency-rate.aspx?currency=USD_RUB";
        private static readonly string JPYCoursePageLink = "https://www.moex.com/ru/derivatives/currency-rate.aspx?currency=JPY_RUB";
        private static readonly string CHFCoursePageLink = "https://www.moex.com/ru/derivatives/currency-rate.aspx?currency=CHF_RUB";
        private static readonly string CADCoursePageLink = "https://www.moex.com/ru/derivatives/currency-rate.aspx?currency=CAD_RUB";

        public static string USDCourse;
        public static string JPYCourse;
        public static string CHFCourse;
        public static string CADCourse;

        public static void UpdateAllCourses ()
        {
            USDCourse = GetCurrentCourse(USDCoursePageHTML);
            JPYCourse = GetCurrentCourse(JPYCoursePageHTML);
            CHFCourse = GetCurrentCourse(CHFCoursePageHTML);
            CADCourse = GetCurrentCourse(CADCoursePageHTML);
        }
        public static void UpdateAllPages()
        {
            Task t1 = Task.Run(() => UpdateUSDPage());
            Task t2 = Task.Run(() => UpdateJPYPage());
            Task t3 = Task.Run(() => UpdateCHFPage());
            Task t4 = Task.Run(() => UpdateCADPage());
            Task.WaitAll(new[] { t1, t2, t3, t4 });
        }

        private static void UpdateUSDPage ()
        {
            using (StreamReader sr = GetStreamReader(USDCoursePageLink))
            {
                USDCoursePageHTML = sr.ReadToEnd();
            }
        }
        private static void UpdateJPYPage()
        {
            using (StreamReader sr = GetStreamReader(JPYCoursePageLink))
            {
                JPYCoursePageHTML = sr.ReadToEnd();
            }
        }
        private static void UpdateCHFPage()
        {
            using (StreamReader sr = GetStreamReader(CHFCoursePageLink))
            {
                CHFCoursePageHTML = sr.ReadToEnd();
            }
        }
        private static void UpdateCADPage()
        {
            using (StreamReader sr = GetStreamReader(CADCoursePageLink))
            {
                CADCoursePageHTML = sr.ReadToEnd();
            }
        }
        public static string GetCurrentCourse (string coursePageHTML)
        {
            string currentCourse;
            string coursePattern = "<b>Текущее значение: (.*)</b>";
            Match matchCourse = Regex.Match(coursePageHTML, coursePattern);
            currentCourse = matchCourse.Groups[1].ToString().Trim();
            return currentCourse;
        }
        public static string GetLastUpdateTime (string coursePageHTML)
        {
            string time;
            string date;
            string localDate = DateTime.Today.ToString().Substring(0, 10); // Обрезаем всё кроме даты
            string timePattern = "</b> на (.*) ";
            string datePattern = "</b> на (.*)</span></div>";
            Match matchTime = Regex.Match(coursePageHTML, timePattern);
            Match matchDate = Regex.Match(coursePageHTML, datePattern);
            time = matchTime.Groups[1].ToString();
            date = matchDate.Groups[1].ToString().Substring(9); // Обрезаем первые 8 символов времени и пробел
            if (String.Compare(date, localDate) == 0)
            {
                return time + " (GMT+3)";
            }
            else return time + $" (GMT+3)  |  {date}";
        }
        private static StreamReader GetStreamReader (string currencyPageLink)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(currencyPageLink);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream());
            return sr;
        }
        public static void UpdateFuturesCollection ()
        {
            if (linkToFuturesBox != null)
            {
                Properties.Settings.Default.futuresCollection.Clear();
                foreach (GroupBox parent in linkToFuturesBox.Controls.OfType<GroupBox>())
                {
                    foreach (CheckBox child in parent.Controls.OfType<CheckBox>())
                    {
                        if (child.Checked == true)
                        {
                            Properties.Settings.Default.futuresCollection.Add(child.Text);
                        }
                    }
                }
                Properties.Settings.Default.Save();
            }
        }
        public static void UpdateFuturesComboBox(ComboBox box)
        {
            box.Items.Clear();
            // Необходимо записывать в обратном порядке т.к. изначально элементы были помещены на форму в обратном порядке (возможно я когда-нибудь это поменяю)
            for (int i = Properties.Settings.Default.futuresCollection.Count - 1; i >= 0; i--) 
            {
                box.Items.Add(Properties.Settings.Default.futuresCollection[i]);
            }
        }
    }
}
