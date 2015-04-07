namespace Planner {
    partial class FinalsCalculatorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalsCalculatorForm));
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lblEditClass = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblRequiredClass1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFinalLetterGrade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblGradeNeeded = new System.Windows.Forms.Label();
            this.lblGradeNeededValue = new System.Windows.Forms.Label();
            this.txtCurrentGrade = new System.Windows.Forms.TextBox();
            this.txtFinalExamPercentage = new System.Windows.Forms.TextBox();
            this.txtDesiredPercentage = new System.Windows.Forms.TextBox();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbClass
            // 
            this.cbClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "Dr. Gallagher",
            "Dr. Vicky Fang",
            "Dr. Schumacher",
            "Dr. Shomper"});
            this.cbClass.Location = new System.Drawing.Point(173, 9);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(207, 21);
            this.cbClass.TabIndex = 46;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // lblEditClass
            // 
            this.lblEditClass.AutoSize = true;
            this.lblEditClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClass.Location = new System.Drawing.Point(65, 9);
            this.lblEditClass.Name = "lblEditClass";
            this.lblEditClass.Size = new System.Drawing.Size(102, 17);
            this.lblEditClass.TabIndex = 47;
            this.lblEditClass.Text = "Select Class:";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(50, 48);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(117, 17);
            this.lblClassName.TabIndex = 49;
            this.lblClassName.Text = "Current Grade:";
            // 
            // lblRequiredClass1
            // 
            this.lblRequiredClass1.AutoSize = true;
            this.lblRequiredClass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass1.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass1.Location = new System.Drawing.Point(276, 48);
            this.lblRequiredClass1.Name = "lblRequiredClass1";
            this.lblRequiredClass1.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass1.TabIndex = 50;
            this.lblRequiredClass1.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Final Exam Worth:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(276, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Desired Grade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Desired Percentage:";
            // 
            // cbFinalLetterGrade
            // 
            this.cbFinalLetterGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFinalLetterGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFinalLetterGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFinalLetterGrade.Enabled = false;
            this.cbFinalLetterGrade.FormattingEnabled = true;
            this.cbFinalLetterGrade.Items.AddRange(new object[] {
            "A",
            "A-",
            "B+",
            "B",
            "B-"});
            this.cbFinalLetterGrade.Location = new System.Drawing.Point(173, 130);
            this.cbFinalLetterGrade.Name = "cbFinalLetterGrade";
            this.cbFinalLetterGrade.Size = new System.Drawing.Size(97, 21);
            this.cbFinalLetterGrade.TabIndex = 57;
            this.cbFinalLetterGrade.SelectedIndexChanged += new System.EventHandler(this.cbFinalLetterGrade_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(276, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "*";
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Location = new System.Drawing.Point(131, 201);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(180, 23);
            this.btnCalculate.TabIndex = 60;
            this.btnCalculate.Text = "Calculate Needed Grade";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblGradeNeeded
            // 
            this.lblGradeNeeded.AutoSize = true;
            this.lblGradeNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeNeeded.Location = new System.Drawing.Point(89, 244);
            this.lblGradeNeeded.Name = "lblGradeNeeded";
            this.lblGradeNeeded.Size = new System.Drawing.Size(119, 17);
            this.lblGradeNeeded.TabIndex = 61;
            this.lblGradeNeeded.Text = "Grade Needed:";
            // 
            // lblGradeNeededValue
            // 
            this.lblGradeNeededValue.AutoSize = true;
            this.lblGradeNeededValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeNeededValue.Location = new System.Drawing.Point(214, 241);
            this.lblGradeNeededValue.Name = "lblGradeNeededValue";
            this.lblGradeNeededValue.Size = new System.Drawing.Size(0, 20);
            this.lblGradeNeededValue.TabIndex = 63;
            // 
            // txtCurrentGrade
            // 
            this.txtCurrentGrade.Location = new System.Drawing.Point(173, 47);
            this.txtCurrentGrade.Name = "txtCurrentGrade";
            this.txtCurrentGrade.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentGrade.TabIndex = 65;
            // 
            // txtFinalExamPercentage
            // 
            this.txtFinalExamPercentage.Location = new System.Drawing.Point(173, 91);
            this.txtFinalExamPercentage.Name = "txtFinalExamPercentage";
            this.txtFinalExamPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtFinalExamPercentage.TabIndex = 66;
            // 
            // txtDesiredPercentage
            // 
            this.txtDesiredPercentage.Location = new System.Drawing.Point(173, 163);
            this.txtDesiredPercentage.Name = "txtDesiredPercentage";
            this.txtDesiredPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtDesiredPercentage.TabIndex = 67;
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Location = new System.Drawing.Point(297, 94);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(119, 13);
            this.lblExplanation.TabIndex = 68;
            this.lblExplanation.Text = "(ex: 20% of Final Grade)";
            // 
            // FinalsCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 280);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.txtDesiredPercentage);
            this.Controls.Add(this.txtFinalExamPercentage);
            this.Controls.Add(this.txtCurrentGrade);
            this.Controls.Add(this.lblGradeNeededValue);
            this.Controls.Add(this.lblGradeNeeded);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFinalLetterGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblRequiredClass1);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.lblEditClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinalsCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Finals Calculator";
            this.Load += new System.EventHandler(this.FinalsCalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblEditClass;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblRequiredClass1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFinalLetterGrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblGradeNeeded;
        private System.Windows.Forms.Label lblGradeNeededValue;
        private System.Windows.Forms.TextBox txtCurrentGrade;
        private System.Windows.Forms.TextBox txtFinalExamPercentage;
        private System.Windows.Forms.TextBox txtDesiredPercentage;
        private System.Windows.Forms.Label lblExplanation;
    }
}