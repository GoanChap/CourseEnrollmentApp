
namespace CourseEnrollmentApp
{
    partial class CourseSelection
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
            this.availableCoursesListBox = new System.Windows.Forms.ListBox();
            this.selectedCoursesListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addAllutton = new System.Windows.Forms.Button();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.finalizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.courseSummaryDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.courseSummaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // availableCoursesListBox
            // 
            this.availableCoursesListBox.FormattingEnabled = true;
            this.availableCoursesListBox.ItemHeight = 25;
            this.availableCoursesListBox.Location = new System.Drawing.Point(66, 62);
            this.availableCoursesListBox.Name = "availableCoursesListBox";
            this.availableCoursesListBox.Size = new System.Drawing.Size(295, 304);
            this.availableCoursesListBox.TabIndex = 0;
            // 
            // selectedCoursesListBox
            // 
            this.selectedCoursesListBox.FormattingEnabled = true;
            this.selectedCoursesListBox.ItemHeight = 25;
            this.selectedCoursesListBox.Location = new System.Drawing.Point(633, 62);
            this.selectedCoursesListBox.Name = "selectedCoursesListBox";
            this.selectedCoursesListBox.Size = new System.Drawing.Size(295, 304);
            this.selectedCoursesListBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(441, 81);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 38);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(441, 143);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(125, 38);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addAllutton
            // 
            this.addAllutton.Location = new System.Drawing.Point(441, 204);
            this.addAllutton.Name = "addAllutton";
            this.addAllutton.Size = new System.Drawing.Size(125, 38);
            this.addAllutton.TabIndex = 4;
            this.addAllutton.Text = "Add All";
            this.addAllutton.UseVisualStyleBackColor = true;
            this.addAllutton.Click += new System.EventHandler(this.addAllutton_Click);
            // 
            // removeAllButton
            // 
            this.removeAllButton.Location = new System.Drawing.Point(441, 264);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(125, 38);
            this.removeAllButton.TabIndex = 5;
            this.removeAllButton.Text = "Remove All";
            this.removeAllButton.UseVisualStyleBackColor = true;
            this.removeAllButton.Click += new System.EventHandler(this.removeAllButton_Click);
            // 
            // finalizeButton
            // 
            this.finalizeButton.Location = new System.Drawing.Point(441, 322);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(125, 38);
            this.finalizeButton.TabIndex = 6;
            this.finalizeButton.Text = "Finalize";
            this.finalizeButton.UseVisualStyleBackColor = true;
            this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Available Courses:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected Courses:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selected Course/s Summary";
            // 
            // courseSummaryDataGridView
            // 
            this.courseSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseSummaryDataGridView.Location = new System.Drawing.Point(66, 425);
            this.courseSummaryDataGridView.Name = "courseSummaryDataGridView";
            this.courseSummaryDataGridView.RowHeadersWidth = 51;
            this.courseSummaryDataGridView.RowTemplate.Height = 24;
            this.courseSummaryDataGridView.Size = new System.Drawing.Size(862, 205);
            this.courseSummaryDataGridView.TabIndex = 10;
            // 
            // CourseSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 651);
            this.Controls.Add(this.courseSummaryDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalizeButton);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.addAllutton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.selectedCoursesListBox);
            this.Controls.Add(this.availableCoursesListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CourseSelection";
            this.Text = "Enroll in Courses";
            this.Load += new System.EventHandler(this.CourseSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseSummaryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox availableCoursesListBox;
        private System.Windows.Forms.ListBox selectedCoursesListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addAllutton;
        private System.Windows.Forms.Button removeAllButton;
        private System.Windows.Forms.Button finalizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView courseSummaryDataGridView;
    }
}

