namespace average
{
    partial class frm_average
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_lesson = new System.Windows.Forms.Label();
            this.lbl_average = new System.Windows.Forms.Label();
            this.lbl_lessonTime = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.flp_lessons = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_addLesson = new System.Windows.Forms.Button();
            this.lbl_results = new System.Windows.Forms.Label();
            this.btn_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_lesson
            // 
            this.lbl_lesson.AutoSize = true;
            this.lbl_lesson.Location = new System.Drawing.Point(10, 9);
            this.lbl_lesson.Name = "lbl_lesson";
            this.lbl_lesson.Size = new System.Drawing.Size(173, 17);
            this.lbl_lesson.TabIndex = 0;
            this.lbl_lesson.Text = "Ders Saati (Zorunlu Değil)";
            // 
            // lbl_average
            // 
            this.lbl_average.AutoSize = true;
            this.lbl_average.Location = new System.Drawing.Point(184, 9);
            this.lbl_average.Name = "lbl_average";
            this.lbl_average.Size = new System.Drawing.Size(66, 17);
            this.lbl_average.TabIndex = 1;
            this.lbl_average.Text = "Ortalama";
            // 
            // lbl_lessonTime
            // 
            this.lbl_lessonTime.AutoSize = true;
            this.lbl_lessonTime.Location = new System.Drawing.Point(255, 9);
            this.lbl_lessonTime.Name = "lbl_lessonTime";
            this.lbl_lessonTime.Size = new System.Drawing.Size(74, 17);
            this.lbl_lessonTime.TabIndex = 2;
            this.lbl_lessonTime.Text = "Ders Saati";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(507, 9);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(48, 17);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "Sonuç";
            // 
            // flp_lessons
            // 
            this.flp_lessons.AutoScroll = true;
            this.flp_lessons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_lessons.Location = new System.Drawing.Point(12, 29);
            this.flp_lessons.Name = "flp_lessons";
            this.flp_lessons.Size = new System.Drawing.Size(375, 367);
            this.flp_lessons.TabIndex = 4;
            this.flp_lessons.WrapContents = false;
            this.flp_lessons.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flp_lessons_ControlAdded);
            // 
            // btn_addLesson
            // 
            this.btn_addLesson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addLesson.Location = new System.Drawing.Point(12, 402);
            this.btn_addLesson.Name = "btn_addLesson";
            this.btn_addLesson.Size = new System.Drawing.Size(375, 36);
            this.btn_addLesson.TabIndex = 0;
            this.btn_addLesson.Text = "Ekle";
            this.btn_addLesson.UseVisualStyleBackColor = true;
            this.btn_addLesson.Click += new System.EventHandler(this.btn_addLesson_Click);
            // 
            // lbl_results
            // 
            this.lbl_results.Location = new System.Drawing.Point(400, 29);
            this.lbl_results.Name = "lbl_results";
            this.lbl_results.Padding = new System.Windows.Forms.Padding(3);
            this.lbl_results.Size = new System.Drawing.Size(274, 367);
            this.lbl_results.TabIndex = 5;
            // 
            // btn_result
            // 
            this.btn_result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_result.Location = new System.Drawing.Point(403, 402);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(271, 36);
            this.btn_result.TabIndex = 6;
            this.btn_result.Text = "Hesapla";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // frm_average
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.lbl_results);
            this.Controls.Add(this.btn_addLesson);
            this.Controls.Add(this.flp_lessons);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_lessonTime);
            this.Controls.Add(this.lbl_average);
            this.Controls.Add(this.lbl_lesson);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_average";
            this.Text = "Belge Durumu Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lesson;
        private System.Windows.Forms.Label lbl_average;
        private System.Windows.Forms.Label lbl_lessonTime;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.FlowLayoutPanel flp_lessons;
        private System.Windows.Forms.Button btn_addLesson;
        private System.Windows.Forms.Label lbl_results;
        private System.Windows.Forms.Button btn_result;
    }
}

