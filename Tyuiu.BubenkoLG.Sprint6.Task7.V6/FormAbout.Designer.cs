namespace Tyuiu.BubenkoLG.Sprint6.Task7.V6
{
    partial class FormAbout_BLG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_BLG));
            textBoxAbout_BLG = new TextBox();
            SuspendLayout();
            // 
            // textBoxAbout_BLG
            // 
            textBoxAbout_BLG.BorderStyle = BorderStyle.None;
            textBoxAbout_BLG.Location = new Point(12, 23);
            textBoxAbout_BLG.Multiline = true;
            textBoxAbout_BLG.Name = "textBoxAbout_BLG";
            textBoxAbout_BLG.ReadOnly = true;
            textBoxAbout_BLG.Size = new Size(617, 350);
            textBoxAbout_BLG.TabIndex = 1;
            textBoxAbout_BLG.Text = resources.GetString("textBoxAbout_BLG.Text");
            // 
            // FormAbout_BLG
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 394);
            Controls.Add(textBoxAbout_BLG);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout_BLG";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxAbout_BLG;
    }
}