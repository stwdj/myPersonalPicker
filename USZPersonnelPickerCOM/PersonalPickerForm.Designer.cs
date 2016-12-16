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
            this.SuspendLayout();
            // 
            // PersonalTextBox
            // 
            this.PersonalTextBox.AcceptsReturn = true;
            this.PersonalTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PersonalTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PersonalTextBox.Location = new System.Drawing.Point(54, 31);
            this.PersonalTextBox.Name = "PersonalTextBox";
            this.PersonalTextBox.Size = new System.Drawing.Size(272, 20);
            this.PersonalTextBox.TabIndex = 0;
            this.PersonalTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PersonalTextBox_KeyDown);
            // 
            // tbSammel
            // 
            this.tbSammel.Location = new System.Drawing.Point(54, 105);
            this.tbSammel.Multiline = true;
            this.tbSammel.Name = "tbSammel";
            this.tbSammel.Size = new System.Drawing.Size(547, 114);
            this.tbSammel.TabIndex = 1;
            // 
            // btEnde
            // 
            this.btEnde.Location = new System.Drawing.Point(428, 27);
            this.btEnde.Name = "btEnde";
            this.btEnde.Size = new System.Drawing.Size(173, 23);
            this.btEnde.TabIndex = 2;
            this.btEnde.Text = "Übernehmen";
            this.btEnde.UseVisualStyleBackColor = true;
            this.btEnde.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonalPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 303);
            this.Controls.Add(this.btEnde);
            this.Controls.Add(this.tbSammel);
            this.Controls.Add(this.PersonalTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}

