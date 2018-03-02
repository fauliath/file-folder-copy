namespace _0._01_File_and_Folder_Copy
{
    partial class MAIN_WINDOW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN_WINDOW));
            this.LABEL_COPY_FROM = new System.Windows.Forms.Label();
            this.TEXT_BOX_COPY_FROM = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BUTTON_CLOSE = new _0._01_File_and_Folder_Copy.OnetsButton();
            this.BUTTON_MINIMISE = new _0._01_File_and_Folder_Copy.OnetsButton();
            this.PANEL_COPY_FROM = new System.Windows.Forms.Panel();
            this.CHECKBOX_OVERWRITE = new System.Windows.Forms.CheckBox();
            this.BUTTON_COPY_FROM = new _0._01_File_and_Folder_Copy.OnetsButton();
            this.PANEL_COPY_TO = new System.Windows.Forms.Panel();
            this.TEXT_BOX_COPY_TO = new System.Windows.Forms.TextBox();
            this.BUTTON_COPY_TO = new _0._01_File_and_Folder_Copy.OnetsButton();
            this.LABEL_COPY_TO = new System.Windows.Forms.Label();
            this.PANEL_OUTPUT = new System.Windows.Forms.Panel();
            this.LABEL_ABOUT = new System.Windows.Forms.Label();
            this.BUTTON_BEGIN_COPY = new _0._01_File_and_Folder_Copy.OnetsButton();
            this.TEXT_BOX_OUTPUT = new System.Windows.Forms.TextBox();
            this.LOGO = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LABEL_FILES_COPIED = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PANEL_COPY_FROM.SuspendLayout();
            this.PANEL_COPY_TO.SuspendLayout();
            this.PANEL_OUTPUT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LABEL_COPY_FROM
            // 
            this.LABEL_COPY_FROM.AutoSize = true;
            this.LABEL_COPY_FROM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LABEL_COPY_FROM.Location = new System.Drawing.Point(74, 12);
            this.LABEL_COPY_FROM.Name = "LABEL_COPY_FROM";
            this.LABEL_COPY_FROM.Size = new System.Drawing.Size(215, 19);
            this.LABEL_COPY_FROM.TabIndex = 3;
            this.LABEL_COPY_FROM.Text = "Select root directory to copy from";
            // 
            // TEXT_BOX_COPY_FROM
            // 
            this.TEXT_BOX_COPY_FROM.Location = new System.Drawing.Point(78, 34);
            this.TEXT_BOX_COPY_FROM.Name = "TEXT_BOX_COPY_FROM";
            this.TEXT_BOX_COPY_FROM.Size = new System.Drawing.Size(554, 20);
            this.TEXT_BOX_COPY_FROM.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BUTTON_CLOSE);
            this.panel1.Controls.Add(this.BUTTON_MINIMISE);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 32);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // BUTTON_CLOSE
            // 
            this.BUTTON_CLOSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BUTTON_CLOSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BUTTON_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_CLOSE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BUTTON_CLOSE.Location = new System.Drawing.Point(716, 3);
            this.BUTTON_CLOSE.Name = "BUTTON_CLOSE";
            this.BUTTON_CLOSE.Size = new System.Drawing.Size(19, 20);
            this.BUTTON_CLOSE.TabIndex = 1;
            this.BUTTON_CLOSE.TabStop = false;
            this.BUTTON_CLOSE.Text = "X";
            this.BUTTON_CLOSE.UseVisualStyleBackColor = false;
            this.BUTTON_CLOSE.Click += new System.EventHandler(this.BUTTON_CLOSE_Click);
            // 
            // BUTTON_MINIMISE
            // 
            this.BUTTON_MINIMISE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BUTTON_MINIMISE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_MINIMISE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BUTTON_MINIMISE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_MINIMISE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_MINIMISE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BUTTON_MINIMISE.Location = new System.Drawing.Point(691, 3);
            this.BUTTON_MINIMISE.Name = "BUTTON_MINIMISE";
            this.BUTTON_MINIMISE.Size = new System.Drawing.Size(19, 20);
            this.BUTTON_MINIMISE.TabIndex = 2;
            this.BUTTON_MINIMISE.TabStop = false;
            this.BUTTON_MINIMISE.Text = "-";
            this.BUTTON_MINIMISE.UseVisualStyleBackColor = false;
            this.BUTTON_MINIMISE.Click += new System.EventHandler(this.BUTTON_MINIMISE_Click);
            // 
            // PANEL_COPY_FROM
            // 
            this.PANEL_COPY_FROM.Controls.Add(this.CHECKBOX_OVERWRITE);
            this.PANEL_COPY_FROM.Controls.Add(this.TEXT_BOX_COPY_FROM);
            this.PANEL_COPY_FROM.Controls.Add(this.BUTTON_COPY_FROM);
            this.PANEL_COPY_FROM.Controls.Add(this.LABEL_COPY_FROM);
            this.PANEL_COPY_FROM.Location = new System.Drawing.Point(0, 41);
            this.PANEL_COPY_FROM.Name = "PANEL_COPY_FROM";
            this.PANEL_COPY_FROM.Size = new System.Drawing.Size(744, 98);
            this.PANEL_COPY_FROM.TabIndex = 7;
            // 
            // CHECKBOX_OVERWRITE
            // 
            this.CHECKBOX_OVERWRITE.AutoSize = true;
            this.CHECKBOX_OVERWRITE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_OVERWRITE.Location = new System.Drawing.Point(78, 66);
            this.CHECKBOX_OVERWRITE.Name = "CHECKBOX_OVERWRITE";
            this.CHECKBOX_OVERWRITE.Size = new System.Drawing.Size(158, 21);
            this.CHECKBOX_OVERWRITE.TabIndex = 0;
            this.CHECKBOX_OVERWRITE.Text = "Overwrite existing files";
            this.CHECKBOX_OVERWRITE.UseVisualStyleBackColor = true;
            // 
            // BUTTON_COPY_FROM
            // 
            this.BUTTON_COPY_FROM.BackColor = System.Drawing.Color.Silver;
            this.BUTTON_COPY_FROM.FlatAppearance.BorderSize = 0;
            this.BUTTON_COPY_FROM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_COPY_FROM.Location = new System.Drawing.Point(638, 34);
            this.BUTTON_COPY_FROM.Name = "BUTTON_COPY_FROM";
            this.BUTTON_COPY_FROM.Size = new System.Drawing.Size(51, 20);
            this.BUTTON_COPY_FROM.TabIndex = 6;
            this.BUTTON_COPY_FROM.TabStop = false;
            this.BUTTON_COPY_FROM.Text = "...";
            this.BUTTON_COPY_FROM.UseVisualStyleBackColor = false;
            this.BUTTON_COPY_FROM.Click += new System.EventHandler(this.BUTTON_COPY_FROM_Click);
            // 
            // PANEL_COPY_TO
            // 
            this.PANEL_COPY_TO.Controls.Add(this.TEXT_BOX_COPY_TO);
            this.PANEL_COPY_TO.Controls.Add(this.BUTTON_COPY_TO);
            this.PANEL_COPY_TO.Controls.Add(this.LABEL_COPY_TO);
            this.PANEL_COPY_TO.Location = new System.Drawing.Point(0, 130);
            this.PANEL_COPY_TO.Name = "PANEL_COPY_TO";
            this.PANEL_COPY_TO.Size = new System.Drawing.Size(744, 68);
            this.PANEL_COPY_TO.TabIndex = 8;
            // 
            // TEXT_BOX_COPY_TO
            // 
            this.TEXT_BOX_COPY_TO.Location = new System.Drawing.Point(78, 34);
            this.TEXT_BOX_COPY_TO.Name = "TEXT_BOX_COPY_TO";
            this.TEXT_BOX_COPY_TO.Size = new System.Drawing.Size(554, 20);
            this.TEXT_BOX_COPY_TO.TabIndex = 4;
            // 
            // BUTTON_COPY_TO
            // 
            this.BUTTON_COPY_TO.BackColor = System.Drawing.Color.Silver;
            this.BUTTON_COPY_TO.FlatAppearance.BorderSize = 0;
            this.BUTTON_COPY_TO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_COPY_TO.Location = new System.Drawing.Point(638, 34);
            this.BUTTON_COPY_TO.Name = "BUTTON_COPY_TO";
            this.BUTTON_COPY_TO.Size = new System.Drawing.Size(51, 20);
            this.BUTTON_COPY_TO.TabIndex = 6;
            this.BUTTON_COPY_TO.TabStop = false;
            this.BUTTON_COPY_TO.Text = "...";
            this.BUTTON_COPY_TO.UseVisualStyleBackColor = false;
            this.BUTTON_COPY_TO.Click += new System.EventHandler(this.BUTTON_COPY_TO_Click);
            // 
            // LABEL_COPY_TO
            // 
            this.LABEL_COPY_TO.AutoSize = true;
            this.LABEL_COPY_TO.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LABEL_COPY_TO.Location = new System.Drawing.Point(74, 12);
            this.LABEL_COPY_TO.Name = "LABEL_COPY_TO";
            this.LABEL_COPY_TO.Size = new System.Drawing.Size(241, 19);
            this.LABEL_COPY_TO.TabIndex = 3;
            this.LABEL_COPY_TO.Text = "Select destination directory to copy to";
            // 
            // PANEL_OUTPUT
            // 
            this.PANEL_OUTPUT.Controls.Add(this.LABEL_FILES_COPIED);
            this.PANEL_OUTPUT.Controls.Add(this.label2);
            this.PANEL_OUTPUT.Controls.Add(this.LABEL_ABOUT);
            this.PANEL_OUTPUT.Controls.Add(this.BUTTON_BEGIN_COPY);
            this.PANEL_OUTPUT.Controls.Add(this.TEXT_BOX_OUTPUT);
            this.PANEL_OUTPUT.Controls.Add(this.LOGO);
            this.PANEL_OUTPUT.Location = new System.Drawing.Point(0, 201);
            this.PANEL_OUTPUT.Name = "PANEL_OUTPUT";
            this.PANEL_OUTPUT.Size = new System.Drawing.Size(740, 365);
            this.PANEL_OUTPUT.TabIndex = 9;
            // 
            // LABEL_ABOUT
            // 
            this.LABEL_ABOUT.AutoSize = true;
            this.LABEL_ABOUT.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_ABOUT.Location = new System.Drawing.Point(288, 349);
            this.LABEL_ABOUT.Name = "LABEL_ABOUT";
            this.LABEL_ABOUT.Size = new System.Drawing.Size(102, 13);
            this.LABEL_ABOUT.TabIndex = 3;
            this.LABEL_ABOUT.Text = "about this application";
            this.LABEL_ABOUT.Click += new System.EventHandler(this.LABEL_ABOUT_Click);
            // 
            // BUTTON_BEGIN_COPY
            // 
            this.BUTTON_BEGIN_COPY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BUTTON_BEGIN_COPY.FlatAppearance.BorderSize = 0;
            this.BUTTON_BEGIN_COPY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_BEGIN_COPY.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_BEGIN_COPY.ForeColor = System.Drawing.Color.White;
            this.BUTTON_BEGIN_COPY.Location = new System.Drawing.Point(291, 3);
            this.BUTTON_BEGIN_COPY.Name = "BUTTON_BEGIN_COPY";
            this.BUTTON_BEGIN_COPY.Size = new System.Drawing.Size(109, 38);
            this.BUTTON_BEGIN_COPY.TabIndex = 12;
            this.BUTTON_BEGIN_COPY.TabStop = false;
            this.BUTTON_BEGIN_COPY.Text = "Begin Copy";
            this.BUTTON_BEGIN_COPY.UseVisualStyleBackColor = false;
            this.BUTTON_BEGIN_COPY.Click += new System.EventHandler(this.BUTTON_BEGIN_COPY_Click);
            // 
            // TEXT_BOX_OUTPUT
            // 
            this.TEXT_BOX_OUTPUT.BackColor = System.Drawing.Color.White;
            this.TEXT_BOX_OUTPUT.Location = new System.Drawing.Point(78, 62);
            this.TEXT_BOX_OUTPUT.Multiline = true;
            this.TEXT_BOX_OUTPUT.Name = "TEXT_BOX_OUTPUT";
            this.TEXT_BOX_OUTPUT.Size = new System.Drawing.Size(538, 284);
            this.TEXT_BOX_OUTPUT.TabIndex = 11;
            // 
            // LOGO
            // 
            this.LOGO.Image = ((System.Drawing.Image)(resources.GetObject("LOGO.Image")));
            this.LOGO.Location = new System.Drawing.Point(627, 258);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(113, 107);
            this.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LOGO.TabIndex = 10;
            this.LOGO.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.PANEL_COPY_TO);
            this.panel2.Controls.Add(this.PANEL_OUTPUT);
            this.panel2.Controls.Add(this.PANEL_COPY_FROM);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 569);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(635, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "files copied";
            // 
            // LABEL_FILES_COPIED
            // 
            this.LABEL_FILES_COPIED.AutoSize = true;
            this.LABEL_FILES_COPIED.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_FILES_COPIED.Location = new System.Drawing.Point(635, 79);
            this.LABEL_FILES_COPIED.Name = "LABEL_FILES_COPIED";
            this.LABEL_FILES_COPIED.Size = new System.Drawing.Size(17, 17);
            this.LABEL_FILES_COPIED.TabIndex = 16;
            this.LABEL_FILES_COPIED.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "File && Folder Copy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "current release 0.17";
            // 
            // MAIN_WINDOW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(747, 573);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MAIN_WINDOW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PANEL_COPY_FROM.ResumeLayout(false);
            this.PANEL_COPY_FROM.PerformLayout();
            this.PANEL_COPY_TO.ResumeLayout(false);
            this.PANEL_COPY_TO.PerformLayout();
            this.PANEL_OUTPUT.ResumeLayout(false);
            this.PANEL_OUTPUT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private OnetsButton BUTTON_CLOSE;
        private OnetsButton BUTTON_MINIMISE;
        private System.Windows.Forms.Label LABEL_COPY_FROM;
        private System.Windows.Forms.TextBox TEXT_BOX_COPY_FROM;
        private System.Windows.Forms.Panel panel1;
        private OnetsButton BUTTON_COPY_FROM;
        private System.Windows.Forms.Panel PANEL_COPY_FROM;
        private System.Windows.Forms.Panel PANEL_COPY_TO;
        private System.Windows.Forms.TextBox TEXT_BOX_COPY_TO;
        private OnetsButton BUTTON_COPY_TO;
        private System.Windows.Forms.Label LABEL_COPY_TO;
        private System.Windows.Forms.PictureBox LOGO;
        private System.Windows.Forms.Panel PANEL_OUTPUT;
        private System.Windows.Forms.TextBox TEXT_BOX_OUTPUT;
        private OnetsButton BUTTON_BEGIN_COPY;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox CHECKBOX_OVERWRITE;
        private System.Windows.Forms.Label LABEL_ABOUT;
        private System.Windows.Forms.Label LABEL_FILES_COPIED;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

