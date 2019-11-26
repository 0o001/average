using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace average
{
    public partial class frm_average : Form
    {
        public frm_average()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                flp_lessons.Controls.Add(new usr_lesson());
            }
        }

        private void btn_addLesson_Click(object sender, EventArgs e)
        {
            flp_lessons.Controls.Add(new usr_lesson());
        }

        private void flp_lessons_ControlAdded(object sender, ControlEventArgs e)
        {
            flp_lessons.ScrollControlIntoView(e.Control);
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            var getPanelControls = flp_lessons.Controls.OfType<usr_lesson>();

            foreach (var item in getPanelControls)
            {
                if (item.cmb_lessonTime.Text.Length == 0)
                {
                    item.cmb_lessonTime.SelectedIndex = 0;
                }

                if (item.txt_average.Text.Length == 0)
                {
                    item.txt_average.Text = "0";
                }
            }

            int totalLesson = flp_lessons.Controls.Count;
            double totalLessonTime = getPanelControls.Sum(item => double.Parse(item.cmb_lessonTime.Text));
            double totalGrade = getPanelControls.Sum(item => double.Parse(item.txt_average.Text));
            double average = totalGrade / totalLessonTime;

            lbl_results.Text = String.Format("Toplam Ders: {0}\nToplam Ders Saati: {1}\nToplam Not: {2}\nOrtalama: {3}", totalLesson, totalLessonTime, totalGrade, average);
        }
    }
}
