namespace WFA_BuildLink
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
            this.BTN_Generate = new System.Windows.Forms.Button();
            this.RTB_Result = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBFilename = new System.Windows.Forms.TextBox();
            this.TB_Template = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_Generate
            // 
            this.BTN_Generate.Location = new System.Drawing.Point(16, 164);
            this.BTN_Generate.Name = "BTN_Generate";
            this.BTN_Generate.Size = new System.Drawing.Size(75, 23);
            this.BTN_Generate.TabIndex = 0;
            this.BTN_Generate.Text = "Generate";
            this.BTN_Generate.UseVisualStyleBackColor = true;
            this.BTN_Generate.Click += new System.EventHandler(this.BTN_Generate_Click);
            // 
            // RTB_Result
            // 
            this.RTB_Result.Location = new System.Drawing.Point(16, 62);
            this.RTB_Result.Name = "RTB_Result";
            this.RTB_Result.Size = new System.Drawing.Size(828, 96);
            this.RTB_Result.TabIndex = 1;
            this.RTB_Result.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the filename:";
            // 
            // TBFilename
            // 
            this.TBFilename.Location = new System.Drawing.Point(140, 4);
            this.TBFilename.Name = "TBFilename";
            this.TBFilename.Size = new System.Drawing.Size(704, 23);
            this.TBFilename.TabIndex = 3;
            // 
            // TB_Template
            // 
            this.TB_Template.Location = new System.Drawing.Point(16, 33);
            this.TB_Template.Name = "TB_Template";
            this.TB_Template.Size = new System.Drawing.Size(828, 23);
            this.TB_Template.TabIndex = 4;
            this.TB_Template.Text = "<li><input type=\"checkbox\" disabled checked><a href=\"C:\\Users\\ericc\\OneDrive - Fl" +
    "owCentric Technologies\\Desktop\\Checklist\\<FileName>\"><FileName></a></input></li>" +
    "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 208);
            this.Controls.Add(this.TB_Template);
            this.Controls.Add(this.TBFilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTB_Result);
            this.Controls.Add(this.BTN_Generate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTN_Generate;
        private RichTextBox RTB_Result;
        private Label label1;
        private TextBox TBFilename;
        private TextBox TB_Template;
    }
}