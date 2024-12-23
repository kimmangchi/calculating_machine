
namespace calculating_machine
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button_Square = new System.Windows.Forms.Button();
            this.button_Root = new System.Windows.Forms.Button();
            this.button_Inverse = new System.Windows.Forms.Button();
            this.button_Percentage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(23, 23);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(441, 21);
            this.textBox_Input.TabIndex = 0;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(23, 75);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(440, 21);
            this.textBox_Result.TabIndex = 1;
            // 
            // button_Square
            // 
            this.button_Square.Location = new System.Drawing.Point(519, 39);
            this.button_Square.Name = "button_Square";
            this.button_Square.Size = new System.Drawing.Size(114, 36);
            this.button_Square.TabIndex = 2;
            this.button_Square.Text = "Square";
            this.button_Square.UseVisualStyleBackColor = true;
            this.button_Square.Click += new System.EventHandler(this.button_Square_Click);
            // 
            // button_Root
            // 
            this.button_Root.Location = new System.Drawing.Point(519, 84);
            this.button_Root.Name = "button_Root";
            this.button_Root.Size = new System.Drawing.Size(113, 39);
            this.button_Root.TabIndex = 3;
            this.button_Root.Text = "Root";
            this.button_Root.UseVisualStyleBackColor = true;
            this.button_Root.Click += new System.EventHandler(this.button_Root_Click);
            // 
            // button_Inverse
            // 
            this.button_Inverse.ForeColor = System.Drawing.Color.Black;
            this.button_Inverse.Location = new System.Drawing.Point(519, 129);
            this.button_Inverse.Name = "button_Inverse";
            this.button_Inverse.Size = new System.Drawing.Size(112, 42);
            this.button_Inverse.TabIndex = 4;
            this.button_Inverse.Text = "Inverse";
            this.button_Inverse.UseVisualStyleBackColor = true;
            this.button_Inverse.Click += new System.EventHandler(this.button_Inverse_Click);
            // 
            // button_Percentage
            // 
            this.button_Percentage.Location = new System.Drawing.Point(520, 182);
            this.button_Percentage.Name = "button_Percentage";
            this.button_Percentage.Size = new System.Drawing.Size(110, 44);
            this.button_Percentage.TabIndex = 5;
            this.button_Percentage.Text = "Percentage";
            this.button_Percentage.UseVisualStyleBackColor = true;
            this.button_Percentage.Click += new System.EventHandler(this.button_Percentage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Percentage);
            this.Controls.Add(this.button_Inverse);
            this.Controls.Add(this.button_Root);
            this.Controls.Add(this.button_Square);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button_Square;
        private System.Windows.Forms.Button button_Root;
        private System.Windows.Forms.Button button_Inverse;
        private System.Windows.Forms.Button button_Percentage;
    }
}

