namespace NoteTakingApp
{
    partial class NoteTaker
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
            this.Titlebox = new System.Windows.Forms.TextBox();
            this.Notebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Previousnotes = new System.Windows.Forms.DataGridView();
            this.Loadbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Newnotebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Previousnotes)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlebox
            // 
            this.Titlebox.Location = new System.Drawing.Point(403, 39);
            this.Titlebox.Name = "Titlebox";
            this.Titlebox.Size = new System.Drawing.Size(375, 20);
            this.Titlebox.TabIndex = 0;
            // 
            // Notebox
            // 
            this.Notebox.Location = new System.Drawing.Point(403, 98);
            this.Notebox.Multiline = true;
            this.Notebox.Name = "Notebox";
            this.Notebox.Size = new System.Drawing.Size(375, 340);
            this.Notebox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Previousnotes
            // 
            this.Previousnotes.BackgroundColor = System.Drawing.Color.White;
            this.Previousnotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Previousnotes.Location = new System.Drawing.Point(12, 12);
            this.Previousnotes.Name = "Previousnotes";
            this.Previousnotes.Size = new System.Drawing.Size(376, 283);
            this.Previousnotes.TabIndex = 4;
            this.Previousnotes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Previousnotes_CellContentDoubleClick);
            // 
            // Loadbutton
            // 
            this.Loadbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbutton.Location = new System.Drawing.Point(12, 317);
            this.Loadbutton.Name = "Loadbutton";
            this.Loadbutton.Size = new System.Drawing.Size(133, 46);
            this.Loadbutton.TabIndex = 5;
            this.Loadbutton.Text = "Load";
            this.Loadbutton.UseVisualStyleBackColor = true;
            this.Loadbutton.Click += new System.EventHandler(this.Loadbutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.Location = new System.Drawing.Point(196, 382);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(133, 46);
            this.Savebutton.TabIndex = 6;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Newnotebutton
            // 
            this.Newnotebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newnotebutton.Location = new System.Drawing.Point(12, 382);
            this.Newnotebutton.Name = "Newnotebutton";
            this.Newnotebutton.Size = new System.Drawing.Size(133, 46);
            this.Newnotebutton.TabIndex = 7;
            this.Newnotebutton.Text = "New note";
            this.Newnotebutton.UseVisualStyleBackColor = true;
            this.Newnotebutton.Click += new System.EventHandler(this.Newnotebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(196, 317);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(133, 46);
            this.Deletebutton.TabIndex = 8;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Newnotebutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Loadbutton);
            this.Controls.Add(this.Previousnotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Notebox);
            this.Controls.Add(this.Titlebox);
            this.Name = "NoteTaker";
            this.Text = "Note";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Previousnotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Titlebox;
        private System.Windows.Forms.TextBox Notebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Previousnotes;
        private System.Windows.Forms.Button Loadbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Newnotebutton;
        private System.Windows.Forms.Button Deletebutton;
    }
}

