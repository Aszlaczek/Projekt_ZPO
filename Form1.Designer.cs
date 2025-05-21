
namespace Projekt_AWzorek_167366
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_add = new Button();
            Lb_title = new Label();
            Btn_close = new Button();
            SuspendLayout();
            // 
            // Btn_add
            // 
            Btn_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_add.Font = new Font("Segoe UI", 12F);
            Btn_add.Location = new Point(569, 369);
            Btn_add.MaximumSize = new Size(150, 50);
            Btn_add.MinimumSize = new Size(150, 50);
            Btn_add.Name = "Btn_add";
            Btn_add.Size = new Size(150, 50);
            Btn_add.TabIndex = 0;
            Btn_add.Text = "Dodaj Nawyk";
            Btn_add.UseVisualStyleBackColor = true;
            Btn_add.Click += Btn_add_Click;
            // 
            // Lb_title
            // 
            Lb_title.AutoSize = true;
            Lb_title.Dock = DockStyle.Top;
            Lb_title.Font = new Font("Segoe UI", 20F);
            Lb_title.Location = new Point(0, 0);
            Lb_title.Margin = new Padding(10, 0, 10, 0);
            Lb_title.Name = "Lb_title";
            Lb_title.Size = new Size(224, 46);
            Lb_title.TabIndex = 1;
            Lb_title.Text = "Twoje Nawyki";
            // 
            // Btn_close
            // 
            Btn_close.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Btn_close.Font = new Font("Segoe UI", 12F);
            Btn_close.Location = new Point(50, 369);
            Btn_close.Name = "Btn_close";
            Btn_close.Size = new Size(150, 50);
            Btn_close.TabIndex = 2;
            Btn_close.Text = "Zamknij";
            Btn_close.UseVisualStyleBackColor = true;
            Btn_close.Click += Btn_close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(Btn_close);
            Controls.Add(Lb_title);
            Controls.Add(Btn_add);
            MaximumSize = new Size(1000, 1000);
            MinimumSize = new Size(500, 500);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button Btn_add;
        private Label Lb_title;
        private Button Btn_close;
    }
}
