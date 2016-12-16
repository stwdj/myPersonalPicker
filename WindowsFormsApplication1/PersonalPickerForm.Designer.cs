namespace USZPersonnelPickerCOM
{
    partial class PersonalPickerForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalPickerForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PersonalTextBox = new System.Windows.Forms.TextBox();
            this.tbSammel = new System.Windows.Forms.TextBox();
            this.btEnde = new System.Windows.Forms.Button();
            this.UebernahmeLabel = new System.Windows.Forms.Label();
            this.EingabeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonalTextBox
            // 
            this.PersonalTextBox.AcceptsReturn = true;
            this.PersonalTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PersonalTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PersonalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalTextBox.Location = new System.Drawing.Point(37, 34);
            this.PersonalTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PersonalTextBox.Name = "PersonalTextBox";
            this.PersonalTextBox.Size = new System.Drawing.Size(650, 24);
            this.PersonalTextBox.TabIndex = 0;
            this.PersonalTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PersonalTextBox_KeyDown);
            // 
            // tbSammel
            // 
            this.tbSammel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbSammel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSammel.Location = new System.Drawing.Point(37, 95);
            this.tbSammel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSammel.Multiline = true;
            this.tbSammel.Name = "tbSammel";
            this.tbSammel.Size = new System.Drawing.Size(650, 150);
            this.tbSammel.TabIndex = 1;
            // 
            // btEnde
            // 
            this.btEnde.Location = new System.Drawing.Point(564, 64);
            this.btEnde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEnde.Name = "btEnde";
            this.btEnde.Size = new System.Drawing.Size(123, 28);
            this.btEnde.TabIndex = 2;
            this.btEnde.Text = "Übernehmen";
            this.btEnde.UseVisualStyleBackColor = true;
            this.btEnde.Click += new System.EventHandler(this.button1_Click);
            // 
            // UebernahmeLabel
            // 
            this.UebernahmeLabel.AutoSize = true;
            this.UebernahmeLabel.Location = new System.Drawing.Point(37, 76);
            this.UebernahmeLabel.Name = "UebernahmeLabel";
            this.UebernahmeLabel.Size = new System.Drawing.Size(392, 16);
            this.UebernahmeLabel.TabIndex = 3;
            this.UebernahmeLabel.Text = "Übernahmefeld (nur Inhalte in diesem Feld werden übernommen)";
            this.UebernahmeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EingabeLabel
            // 
            this.EingabeLabel.AutoSize = true;
            this.EingabeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EingabeLabel.Location = new System.Drawing.Point(37, 14);
            this.EingabeLabel.Name = "EingabeLabel";
            this.EingabeLabel.Size = new System.Drawing.Size(70, 16);
            this.EingabeLabel.TabIndex = 4;
            this.EingabeLabel.Text = "Eingabe:";
            this.EingabeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PersonalPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 262);
            this.Controls.Add(this.EingabeLabel);
            this.Controls.Add(this.UebernahmeLabel);
            this.Controls.Add(this.btEnde);
            this.Controls.Add(this.tbSammel);
            this.Controls.Add(this.PersonalTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PersonalPickerForm";
            this.Text = "Personal Picker";
            this.Load += new System.EventHandler(this.PersonalPickerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox PersonalTextBox;
        private System.Windows.Forms.TextBox tbSammel;
        private System.Windows.Forms.Button btEnde;
        private System.Windows.Forms.Label UebernahmeLabel;
        private System.Windows.Forms.Label EingabeLabel;
    }
}

