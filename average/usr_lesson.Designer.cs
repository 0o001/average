namespace average
{
    partial class usr_lesson
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_lesson = new System.Windows.Forms.ComboBox();
            this.txt_average = new System.Windows.Forms.TextBox();
            this.cmb_lessonTime = new System.Windows.Forms.ComboBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_lesson
            // 
            this.cmb_lesson.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_lesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_lesson.FormattingEnabled = true;
            this.cmb_lesson.Items.AddRange(new object[] {
            "DİĞER",
            "BEDEN EĞİTİMİ",
            "BİYOLOJİ",
            "COĞRAFYA",
            "ÇAĞDAŞ TÜRK DÜNYA TARİHİ",
            "DİL VE ANLATIM",
            "DİN KÜLTÜRÜ",
            "FELSEFE",
            "FİZİK",
            "GEOMETRİ",
            "GÖRSEL SANATLAR-MÜZİK",
            "YABANCI DİL",
            "YABANCI DİL 2",
            "KİMYA",
            "MANTIK",
            "MATEMATİK",
            "MİLLİ GÜVENLİK BİLGİSİ",
            "OSMANLI TÜRKÇESİ",
            "PSİKOLOJİ",
            "SAĞLIK BİLGİSİ",
            "SEÇMELİ 1",
            "SEÇMELİ 2",
            "SEÇMELİ 3",
            "SOSYOLOJİ",
            "T.C. İNKILAP TARİHİ",
            "TARİH",
            "TRAFİK VE İLKYARDIM",
            "TÜRK EDEBİYATI",
            "TÜRKÇE"});
            this.cmb_lesson.Location = new System.Drawing.Point(1, 3);
            this.cmb_lesson.Name = "cmb_lesson";
            this.cmb_lesson.Size = new System.Drawing.Size(148, 24);
            this.cmb_lesson.TabIndex = 0;
            // 
            // txt_average
            // 
            this.txt_average.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_average.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_average.Location = new System.Drawing.Point(157, 3);
            this.txt_average.MaxLength = 3;
            this.txt_average.Name = "txt_average";
            this.txt_average.Size = new System.Drawing.Size(62, 24);
            this.txt_average.TabIndex = 1;
            this.txt_average.Text = "0";
            this.txt_average.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_average_KeyPress);
            // 
            // cmb_lessonTime
            // 
            this.cmb_lessonTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_lessonTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_lessonTime.FormattingEnabled = true;
            this.cmb_lessonTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_lessonTime.Location = new System.Drawing.Point(226, 3);
            this.cmb_lessonTime.Name = "cmb_lessonTime";
            this.cmb_lessonTime.Size = new System.Drawing.Size(73, 24);
            this.cmb_lessonTime.TabIndex = 2;
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_remove.Location = new System.Drawing.Point(306, 3);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(35, 24);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "x";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // usr_lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.cmb_lessonTime);
            this.Controls.Add(this.txt_average);
            this.Controls.Add(this.cmb_lesson);
            this.Name = "usr_lesson";
            this.Size = new System.Drawing.Size(343, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmb_lesson;
        public System.Windows.Forms.TextBox txt_average;
        public System.Windows.Forms.ComboBox cmb_lessonTime;
        private System.Windows.Forms.Button btn_remove;
    }
}
