namespace Projekt_AWzorek_167366
{
    partial class ShowHabit
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            Lb_one_habit = new Label();
            checkBox1 = new CheckBox();
            Btn_delete_habit = new Button();
            Btn_description = new Button();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // Lb_one_habit
            // 
            Lb_one_habit.AutoSize = true;
            Lb_one_habit.Dock = DockStyle.Top;
            Lb_one_habit.Location = new Point(0, 0);
            Lb_one_habit.Margin = new Padding(2);
            Lb_one_habit.Name = "Lb_one_habit";
            Lb_one_habit.Size = new Size(0, 20);
            Lb_one_habit.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(261, 82);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Zakończ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Btn_delete_habit
            // 
            Btn_delete_habit.Dock = DockStyle.Fill;
            Btn_delete_habit.Location = new Point(0, 0);
            Btn_delete_habit.Name = "Btn_delete_habit";
            Btn_delete_habit.Size = new Size(180, 36);
            Btn_delete_habit.TabIndex = 2;
            Btn_delete_habit.Text = "Usuń";
            Btn_delete_habit.UseVisualStyleBackColor = true;
            // 
            // Btn_description
            // 
            Btn_description.Dock = DockStyle.Fill;
            Btn_description.Location = new Point(0, 0);
            Btn_description.Name = "Btn_description";
            Btn_description.Size = new Size(168, 36);
            Btn_description.TabIndex = 3;
            Btn_description.Text = "Opis";
            Btn_description.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Bottom;
            splitContainer1.Location = new Point(0, 164);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(Btn_description);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(Btn_delete_habit);
            splitContainer1.Size = new Size(350, 36);
            splitContainer1.SplitterDistance = 168;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 0;
            // 
            // ShowHabit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(checkBox1);
            Controls.Add(Lb_one_habit);
            MaximumSize = new Size(350, 200);
            MinimumSize = new Size(250, 200);
            Name = "ShowHabit";
            Size = new Size(350, 200);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb_one_habit;
        private CheckBox checkBox1;
        private Button Btn_delete_habit;
        private Button Btn_description;
        private SplitContainer splitContainer1;
    }
}
