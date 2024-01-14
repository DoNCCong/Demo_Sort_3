namespace Demo_Sort
{
    partial class DoAn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Container_bt = new System.Windows.Forms.Panel();
            this.Selection_Sort = new System.Windows.Forms.Button();
            this.bt_init = new System.Windows.Forms.Button();
            this.bt_Insert_Sort = new System.Windows.Forms.Button();
            this.bt_shakeSort = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.bt_music = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Container_bt
            // 
            this.Container_bt.BackColor = System.Drawing.Color.Aqua;
            this.Container_bt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Container_bt.Location = new System.Drawing.Point(33, 89);
            this.Container_bt.Name = "Container_bt";
            this.Container_bt.Size = new System.Drawing.Size(1012, 357);
            this.Container_bt.TabIndex = 0;
            // 
            // Selection_Sort
            // 
            this.Selection_Sort.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Selection_Sort.FlatAppearance.BorderSize = 0;
            this.Selection_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selection_Sort.Location = new System.Drawing.Point(90, 479);
            this.Selection_Sort.Name = "Selection_Sort";
            this.Selection_Sort.Size = new System.Drawing.Size(214, 37);
            this.Selection_Sort.TabIndex = 0;
            this.Selection_Sort.Text = "Selection_Sort";
            this.Selection_Sort.UseVisualStyleBackColor = true;
            this.Selection_Sort.Click += new System.EventHandler(this.Selection_Sort_Click);
            // 
            // bt_init
            // 
            this.bt_init.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.bt_init.FlatAppearance.BorderSize = 0;
            this.bt_init.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_init.Location = new System.Drawing.Point(90, 32);
            this.bt_init.Name = "bt_init";
            this.bt_init.Size = new System.Drawing.Size(214, 37);
            this.bt_init.TabIndex = 1;
            this.bt_init.Text = "Initialization";
            this.bt_init.UseVisualStyleBackColor = true;
            this.bt_init.Click += new System.EventHandler(this.bt_init_Click);
            // 
            // bt_Insert_Sort
            // 
            this.bt_Insert_Sort.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.bt_Insert_Sort.FlatAppearance.BorderSize = 0;
            this.bt_Insert_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Insert_Sort.Location = new System.Drawing.Point(418, 479);
            this.bt_Insert_Sort.Name = "bt_Insert_Sort";
            this.bt_Insert_Sort.Size = new System.Drawing.Size(214, 37);
            this.bt_Insert_Sort.TabIndex = 2;
            this.bt_Insert_Sort.Text = "Insert_Sort";
            this.bt_Insert_Sort.UseVisualStyleBackColor = true;
            this.bt_Insert_Sort.Click += new System.EventHandler(this.bt_Insert_Sort_Click);
            // 
            // bt_shakeSort
            // 
            this.bt_shakeSort.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.bt_shakeSort.FlatAppearance.BorderSize = 0;
            this.bt_shakeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_shakeSort.Location = new System.Drawing.Point(722, 479);
            this.bt_shakeSort.Name = "bt_shakeSort";
            this.bt_shakeSort.Size = new System.Drawing.Size(214, 37);
            this.bt_shakeSort.TabIndex = 3;
            this.bt_shakeSort.Text = "Shake_Sort";
            this.bt_shakeSort.UseVisualStyleBackColor = true;
            this.bt_shakeSort.Click += new System.EventHandler(this.bt_shakeSort_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.info.Location = new System.Drawing.Point(323, 39);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(380, 24);
            this.info.TabIndex = 4;
            this.info.Text = "Khởi Tạo Lại Các Cột Có Độ Dài Khác Nhau.";
            // 
            // bt_music
            // 
            this.bt_music.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_music.Location = new System.Drawing.Point(90, 536);
            this.bt_music.Name = "bt_music";
            this.bt_music.Size = new System.Drawing.Size(119, 35);
            this.bt_music.TabIndex = 5;
            this.bt_music.Text = "music";
            this.bt_music.UseVisualStyleBackColor = true;
            this.bt_music.Click += new System.EventHandler(this.bt_music_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Close.Location = new System.Drawing.Point(873, 536);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(102, 35);
            this.bt_Close.TabIndex = 6;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // DoAn
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1076, 583);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_music);
            this.Controls.Add(this.info);
            this.Controls.Add(this.bt_shakeSort);
            this.Controls.Add(this.bt_Insert_Sort);
            this.Controls.Add(this.bt_init);
            this.Controls.Add(this.Selection_Sort);
            this.Controls.Add(this.Container_bt);
            this.Name = "DoAn";
            this.Text = "DoAnNhom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Container_bt;
        private System.Windows.Forms.Button Selection_Sort;
        private System.Windows.Forms.Button bt_init;
        private System.Windows.Forms.Button bt_Insert_Sort;
        private System.Windows.Forms.Button bt_shakeSort;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button bt_music;
        private System.Windows.Forms.Button bt_Close;
    }
}

