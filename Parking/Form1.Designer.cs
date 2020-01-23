namespace Parking
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.txtCreditAdded = new System.Windows.Forms.TextBox();
      this.txtOneParkNoCard = new System.Windows.Forms.TextBox();
      this.txtOneParkWithCard = new System.Windows.Forms.TextBox();
      this.txtDaysParking = new System.Windows.Forms.TextBox();
      this.txtCreditRemaining = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(394, 234);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(130, 43);
      this.button1.TabIndex = 0;
      this.button1.Text = "&Caculate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(394, 446);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(130, 43);
      this.button2.TabIndex = 1;
      this.button2.Text = "E&xit";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // txtCreditAdded
      // 
      this.txtCreditAdded.Location = new System.Drawing.Point(394, 34);
      this.txtCreditAdded.Name = "txtCreditAdded";
      this.txtCreditAdded.Size = new System.Drawing.Size(130, 31);
      this.txtCreditAdded.TabIndex = 2;
      // 
      // txtOneParkNoCard
      // 
      this.txtOneParkNoCard.Location = new System.Drawing.Point(394, 107);
      this.txtOneParkNoCard.Name = "txtOneParkNoCard";
      this.txtOneParkNoCard.Size = new System.Drawing.Size(130, 31);
      this.txtOneParkNoCard.TabIndex = 3;
      this.txtOneParkNoCard.Text = "5.00";
      // 
      // txtOneParkWithCard
      // 
      this.txtOneParkWithCard.Location = new System.Drawing.Point(394, 175);
      this.txtOneParkWithCard.Name = "txtOneParkWithCard";
      this.txtOneParkWithCard.Size = new System.Drawing.Size(130, 31);
      this.txtOneParkWithCard.TabIndex = 4;
      this.txtOneParkWithCard.Text = "2.50";
      // 
      // txtDaysParking
      // 
      this.txtDaysParking.Location = new System.Drawing.Point(394, 309);
      this.txtDaysParking.Name = "txtDaysParking";
      this.txtDaysParking.ReadOnly = true;
      this.txtDaysParking.Size = new System.Drawing.Size(130, 31);
      this.txtDaysParking.TabIndex = 5;
      // 
      // txtCreditRemaining
      // 
      this.txtCreditRemaining.Location = new System.Drawing.Point(394, 370);
      this.txtCreditRemaining.Name = "txtCreditRemaining";
      this.txtCreditRemaining.ReadOnly = true;
      this.txtCreditRemaining.Size = new System.Drawing.Size(130, 31);
      this.txtCreditRemaining.TabIndex = 6;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(296, 25);
      this.label1.TabIndex = 7;
      this.label1.Text = "Credit added to Campus Card";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 107);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(342, 25);
      this.label2.TabIndex = 8;
      this.label2.Text = "Parking cost without Campus Card";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(23, 175);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(312, 25);
      this.label3.TabIndex = 9;
      this.label3.Text = "Parking cost with Campus Card";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(23, 309);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(264, 25);
      this.label4.TabIndex = 10;
      this.label4.Text = "Number of days of parking";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(23, 370);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(169, 25);
      this.label5.TabIndex = 11;
      this.label5.Text = "Credit remaining";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(555, 542);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtCreditRemaining);
      this.Controls.Add(this.txtDaysParking);
      this.Controls.Add(this.txtOneParkWithCard);
      this.Controls.Add(this.txtOneParkNoCard);
      this.Controls.Add(this.txtCreditAdded);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox txtCreditAdded;
    private System.Windows.Forms.TextBox txtOneParkNoCard;
    private System.Windows.Forms.TextBox txtOneParkWithCard;
    private System.Windows.Forms.TextBox txtDaysParking;
    private System.Windows.Forms.TextBox txtCreditRemaining;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
  }
}

