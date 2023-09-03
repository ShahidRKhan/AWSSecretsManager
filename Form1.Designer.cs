namespace FetchSecretManager
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
            txtInputkey = new TextBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            btnFetch = new Button();
            btnCopy = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // txtInputkey
            // 
            txtInputkey.Location = new Point(160, 50);
            txtInputkey.Name = "txtInputkey";
            txtInputkey.Size = new Size(574, 23);
            txtInputkey.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 50);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter key Name";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(42, 172);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(692, 443);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btnFetch
            // 
            btnFetch.Location = new Point(268, 111);
            btnFetch.Name = "btnFetch";
            btnFetch.Size = new Size(178, 23);
            btnFetch.TabIndex = 3;
            btnFetch.Text = "Fetch";
            btnFetch.UseVisualStyleBackColor = true;
            btnFetch.Click += btnFetch_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(513, 646);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(107, 23);
            btnCopy.TabIndex = 4;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(626, 646);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(108, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 717);
            Controls.Add(btnReset);
            Controls.Add(btnCopy);
            Controls.Add(btnFetch);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(txtInputkey);
            Name = "Form1";
            Text = "Secrets Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputkey;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button btnFetch;
        private Button btnCopy;
        private Button btnReset;
    }
}