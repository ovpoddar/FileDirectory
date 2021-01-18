
namespace FileDirectory
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
            this.Input = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.Openfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(13, 13);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(663, 23);
            this.Input.TabIndex = 0;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(719, 13);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(69, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Get";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(13, 42);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(775, 396);
            this.Output.TabIndex = 2;
            // 
            // Openfile
            // 
            this.Openfile.Location = new System.Drawing.Point(683, 13);
            this.Openfile.Name = "Openfile";
            this.Openfile.Size = new System.Drawing.Size(30, 23);
            this.Openfile.TabIndex = 3;
            this.Openfile.Text = "...";
            this.Openfile.UseVisualStyleBackColor = true;
            this.Openfile.Click += new System.EventHandler(this.Openfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Openfile);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.button);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Openfile;
    }
}

