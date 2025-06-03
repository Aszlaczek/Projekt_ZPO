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
            SuspendLayout();
            // 
            // Lb_one_habit
            // 
            Lb_one_habit.AutoSize = true;
            Lb_one_habit.Location = new Point(37, 12);
            Lb_one_habit.Name = "Lb_one_habit";
            Lb_one_habit.Size = new Size(0, 20);
            Lb_one_habit.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(237, 94);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Done";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Btn_delete_habit
            // 
            Btn_delete_habit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_delete_habit.Location = new Point(216, 145);
            Btn_delete_habit.Name = "Btn_delete_habit";
            Btn_delete_habit.Size = new Size(94, 29);
            Btn_delete_habit.TabIndex = 2;
            Btn_delete_habit.Text = "Delete";
            Btn_delete_habit.UseVisualStyleBackColor = true;
            // 
            // Btn_description
            // 
            Btn_description.Location = new Point(37, 145);
            Btn_description.Name = "Btn_description";
            Btn_description.Size = new Size(94, 29);
            Btn_description.TabIndex = 3;
            Btn_description.Text = "Description";
            Btn_description.UseVisualStyleBackColor = true;
            // 
            // ShowHabit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Btn_description);
            Controls.Add(Btn_delete_habit);
            Controls.Add(checkBox1);
            Controls.Add(Lb_one_habit);
            MaximumSize = new Size(350, 200);
            MinimumSize = new Size(250, 200);
            Name = "ShowHabit";
            Size = new Size(350, 200);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb_one_habit;
        private CheckBox checkBox1;
        private Button Btn_delete_habit;
        private Button Btn_description;
    }
}
