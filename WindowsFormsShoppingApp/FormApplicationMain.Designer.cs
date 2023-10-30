namespace WindowsFormsShoppingApp
{
    partial class FormApplicationMain
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
            this.richTextBoxEditor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxEditor
            // 
            this.richTextBoxEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEditor.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEditor.Name = "richTextBoxEditor";
            this.richTextBoxEditor.Size = new System.Drawing.Size(1479, 859);
            this.richTextBoxEditor.TabIndex = 0;
            this.richTextBoxEditor.Text = "";
            // 
            // FormApplicationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 859);
            this.Controls.Add(this.richTextBoxEditor);
            this.Name = "FormApplicationMain";
            this.Text = "FormApplicationMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxEditor;
    }
}