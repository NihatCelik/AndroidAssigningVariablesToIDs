namespace AndroidAssigningVariablesToIDs
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFragment = new System.Windows.Forms.RadioButton();
            this.rbActivity = new System.Windows.Forms.RadioButton();
            this.tnDefinitionVariables = new System.Windows.Forms.Button();
            this.btnAssigningVariablesToIDs = new System.Windows.Forms.Button();
            this.txtXml = new System.Windows.Forms.RichTextBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFragment);
            this.panel1.Controls.Add(this.rbActivity);
            this.panel1.Controls.Add(this.tnDefinitionVariables);
            this.panel1.Controls.Add(this.btnAssigningVariablesToIDs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(400, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 527);
            this.panel1.TabIndex = 1;
            // 
            // rbFragment
            // 
            this.rbFragment.AutoSize = true;
            this.rbFragment.Location = new System.Drawing.Point(13, 289);
            this.rbFragment.Name = "rbFragment";
            this.rbFragment.Size = new System.Drawing.Size(69, 17);
            this.rbFragment.TabIndex = 1;
            this.rbFragment.Text = "Fragment";
            this.rbFragment.UseVisualStyleBackColor = true;
            // 
            // rbActivity
            // 
            this.rbActivity.AutoSize = true;
            this.rbActivity.Checked = true;
            this.rbActivity.Location = new System.Drawing.Point(13, 266);
            this.rbActivity.Name = "rbActivity";
            this.rbActivity.Size = new System.Drawing.Size(59, 17);
            this.rbActivity.TabIndex = 1;
            this.rbActivity.TabStop = true;
            this.rbActivity.Text = "Activity";
            this.rbActivity.UseVisualStyleBackColor = true;
            // 
            // btnDegiskenleriTanimla
            // 
            this.tnDefinitionVariables.Location = new System.Drawing.Point(13, 146);
            this.tnDefinitionVariables.Name = "btnDegiskenleriTanimla";
            this.tnDefinitionVariables.Size = new System.Drawing.Size(98, 54);
            this.tnDefinitionVariables.TabIndex = 0;
            this.tnDefinitionVariables.Text = "Değişkenleri Tanımla";
            this.tnDefinitionVariables.UseVisualStyleBackColor = true;
            this.tnDefinitionVariables.Click += new System.EventHandler(this.btnDefinitionVariables_Click);
            // 
            // btnNesneleriDegiskenlereAl
            // 
            this.btnAssigningVariablesToIDs.Location = new System.Drawing.Point(13, 206);
            this.btnAssigningVariablesToIDs.Name = "btnNesneleriDegiskenlereAl";
            this.btnAssigningVariablesToIDs.Size = new System.Drawing.Size(98, 54);
            this.btnAssigningVariablesToIDs.TabIndex = 0;
            this.btnAssigningVariablesToIDs.Text = "Nesneleri Değişkenlere Al";
            this.btnAssigningVariablesToIDs.UseVisualStyleBackColor = true;
            this.btnAssigningVariablesToIDs.Click += new System.EventHandler(this.btnAssigningVariablesToIDs_Click);
            // 
            // txtXml
            // 
            this.txtXml.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtXml.Location = new System.Drawing.Point(0, 0);
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(400, 527);
            this.txtXml.TabIndex = 3;
            this.txtXml.Text = "";
            // 
            // txtSonuc
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(524, 0);
            this.txtResult.Name = "txtSonuc";
            this.txtResult.Size = new System.Drawing.Size(400, 527);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 527);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtXml);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tnDefinitionVariables;
        private System.Windows.Forms.Button btnAssigningVariablesToIDs;
        private System.Windows.Forms.RadioButton rbFragment;
        private System.Windows.Forms.RadioButton rbActivity;
        private System.Windows.Forms.RichTextBox txtXml;
        private System.Windows.Forms.RichTextBox txtResult;
    }
}

