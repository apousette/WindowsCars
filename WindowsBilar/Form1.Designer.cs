
namespace WindowsBilar
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
            this.allcars = new System.Windows.Forms.Button();
            this.redcars = new System.Windows.Forms.Button();
            this.oldercars = new System.Windows.Forms.Button();
            this.greyvolvo = new System.Windows.Forms.Button();
            this.bmwrange = new System.Windows.Forms.Button();
            this.mostexpensive = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // allcars
            // 
            this.allcars.Location = new System.Drawing.Point(250, 11);
            this.allcars.Name = "allcars";
            this.allcars.Size = new System.Drawing.Size(238, 74);
            this.allcars.TabIndex = 0;
            this.allcars.Text = "button1";
            this.allcars.UseVisualStyleBackColor = true;
            // 
            // redcars
            // 
            this.redcars.Location = new System.Drawing.Point(14, 109);
            this.redcars.Name = "redcars";
            this.redcars.Size = new System.Drawing.Size(141, 72);
            this.redcars.TabIndex = 1;
            this.redcars.Text = "button1";
            this.redcars.UseVisualStyleBackColor = true;
            // 
            // oldercars
            // 
            this.oldercars.Location = new System.Drawing.Point(171, 111);
            this.oldercars.Name = "oldercars";
            this.oldercars.Size = new System.Drawing.Size(135, 69);
            this.oldercars.TabIndex = 2;
            this.oldercars.Text = "button1";
            this.oldercars.UseVisualStyleBackColor = true;
            // 
            // greyvolvo
            // 
            this.greyvolvo.Location = new System.Drawing.Point(329, 113);
            this.greyvolvo.Name = "greyvolvo";
            this.greyvolvo.Size = new System.Drawing.Size(141, 67);
            this.greyvolvo.TabIndex = 3;
            this.greyvolvo.Text = "button1";
            this.greyvolvo.UseVisualStyleBackColor = true;
            // 
            // bmwrange
            // 
            this.bmwrange.Location = new System.Drawing.Point(506, 115);
            this.bmwrange.Name = "bmwrange";
            this.bmwrange.Size = new System.Drawing.Size(131, 65);
            this.bmwrange.TabIndex = 4;
            this.bmwrange.Text = "button1";
            this.bmwrange.UseVisualStyleBackColor = true;
            // 
            // mostexpensive
            // 
            this.mostexpensive.Location = new System.Drawing.Point(669, 118);
            this.mostexpensive.Name = "mostexpensive";
            this.mostexpensive.Size = new System.Drawing.Size(115, 62);
            this.mostexpensive.TabIndex = 5;
            this.mostexpensive.Text = "button1";
            this.mostexpensive.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(16, 191);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(767, 251);
            this.listBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.mostexpensive);
            this.Controls.Add(this.bmwrange);
            this.Controls.Add(this.greyvolvo);
            this.Controls.Add(this.oldercars);
            this.Controls.Add(this.redcars);
            this.Controls.Add(this.allcars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button allcars;
        private System.Windows.Forms.Button redcars;
        private System.Windows.Forms.Button oldercars;
        private System.Windows.Forms.Button greyvolvo;
        private System.Windows.Forms.Button bmwrange;
        private System.Windows.Forms.Button mostexpensive;
        private System.Windows.Forms.ListBox listBox;
    }
}

