namespace WindowsFormsApp2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageisci = new System.Windows.Forms.TabPage();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblyas = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lbliscikod = new System.Windows.Forms.Label();
            this.tabPageodenis = new System.Windows.Forms.TabPage();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.txtPayTitle = new System.Windows.Forms.TextBox();
            this.txtPayCode = new System.Windows.Forms.TextBox();
            this.lblMebleg = new System.Windows.Forms.Label();
            this.lblOdenisAdi = new System.Windows.Forms.Label();
            this.lblIsciKodu = new System.Windows.Forms.Label();
            this.tabPagestatistika = new System.Windows.Forms.TabPage();
            this.lstStatPayments = new System.Windows.Forms.ListBox();
            this.lblStatInfo = new System.Windows.Forms.Label();
            this.btnSearchStat = new System.Windows.Forms.Button();
            this.txtStatCode = new System.Windows.Forms.TextBox();
            this.lblkod = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageisci.SuspendLayout();
            this.tabPageodenis.SuspendLayout();
            this.tabPagestatistika.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageisci);
            this.tabControl1.Controls.Add(this.tabPageodenis);
            this.tabControl1.Controls.Add(this.tabPagestatistika);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(397, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageisci
            // 
            this.tabPageisci.Controls.Add(this.lstEmployees);
            this.tabPageisci.Controls.Add(this.btnAddEmployee);
            this.tabPageisci.Controls.Add(this.txtAge);
            this.tabPageisci.Controls.Add(this.txtLastName);
            this.tabPageisci.Controls.Add(this.txtFirstName);
            this.tabPageisci.Controls.Add(this.txtCode);
            this.tabPageisci.Controls.Add(this.lblyas);
            this.tabPageisci.Controls.Add(this.lblsoyad);
            this.tabPageisci.Controls.Add(this.lblad);
            this.tabPageisci.Controls.Add(this.lbliscikod);
            this.tabPageisci.Location = new System.Drawing.Point(4, 22);
            this.tabPageisci.Name = "tabPageisci";
            this.tabPageisci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageisci.Size = new System.Drawing.Size(389, 400);
            this.tabPageisci.TabIndex = 0;
            this.tabPageisci.Text = "İşçi əlavə et";
            this.tabPageisci.UseVisualStyleBackColor = true;
            this.tabPageisci.Click += new System.EventHandler(this.tabPageisci_Click);
            // 
            // lstEmployees
            // 
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.Location = new System.Drawing.Point(9, 155);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(365, 238);
            this.lstEmployees.TabIndex = 9;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.Location = new System.Drawing.Point(9, 122);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(157, 27);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "İşçi Əlavə Et";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(66, 87);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(308, 20);
            this.txtAge.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(66, 61);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(308, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(66, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(308, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(66, 9);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(308, 20);
            this.txtCode.TabIndex = 4;
            this.txtCode.TextChanged += new System.EventHandler(this.txtkod_TextChanged);
            // 
            // lblyas
            // 
            this.lblyas.AutoSize = true;
            this.lblyas.Location = new System.Drawing.Point(6, 90);
            this.lblyas.Name = "lblyas";
            this.lblyas.Size = new System.Drawing.Size(28, 13);
            this.lblyas.TabIndex = 3;
            this.lblyas.Text = "Yaş:";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(6, 64);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(40, 13);
            this.lblsoyad.TabIndex = 2;
            this.lblsoyad.Text = "Soyad:";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(6, 38);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(23, 13);
            this.lblad.TabIndex = 1;
            this.lblad.Text = "Ad:";
            // 
            // lbliscikod
            // 
            this.lbliscikod.AutoSize = true;
            this.lbliscikod.Location = new System.Drawing.Point(6, 12);
            this.lbliscikod.Name = "lbliscikod";
            this.lbliscikod.Size = new System.Drawing.Size(54, 13);
            this.lbliscikod.TabIndex = 0;
            this.lbliscikod.Text = "İşçi Kodu:";
            // 
            // tabPageodenis
            // 
            this.tabPageodenis.Controls.Add(this.btnAddPayment);
            this.tabPageodenis.Controls.Add(this.txtPayAmount);
            this.tabPageodenis.Controls.Add(this.txtPayTitle);
            this.tabPageodenis.Controls.Add(this.txtPayCode);
            this.tabPageodenis.Controls.Add(this.lblMebleg);
            this.tabPageodenis.Controls.Add(this.lblOdenisAdi);
            this.tabPageodenis.Controls.Add(this.lblIsciKodu);
            this.tabPageodenis.Location = new System.Drawing.Point(4, 22);
            this.tabPageodenis.Name = "tabPageodenis";
            this.tabPageodenis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageodenis.Size = new System.Drawing.Size(389, 400);
            this.tabPageodenis.TabIndex = 1;
            this.tabPageodenis.Text = "Ödəniş yaz";
            this.tabPageodenis.UseVisualStyleBackColor = true;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(9, 109);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(141, 24);
            this.btnAddPayment.TabIndex = 6;
            this.btnAddPayment.Text = "Ödəniş Yaz";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(75, 69);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(294, 20);
            this.txtPayAmount.TabIndex = 5;
            // 
            // txtPayTitle
            // 
            this.txtPayTitle.Location = new System.Drawing.Point(75, 39);
            this.txtPayTitle.Name = "txtPayTitle";
            this.txtPayTitle.Size = new System.Drawing.Size(294, 20);
            this.txtPayTitle.TabIndex = 4;
            // 
            // txtPayCode
            // 
            this.txtPayCode.Location = new System.Drawing.Point(75, 10);
            this.txtPayCode.Name = "txtPayCode";
            this.txtPayCode.Size = new System.Drawing.Size(294, 20);
            this.txtPayCode.TabIndex = 3;
            // 
            // lblMebleg
            // 
            this.lblMebleg.AutoSize = true;
            this.lblMebleg.Location = new System.Drawing.Point(6, 72);
            this.lblMebleg.Name = "lblMebleg";
            this.lblMebleg.Size = new System.Drawing.Size(45, 13);
            this.lblMebleg.TabIndex = 2;
            this.lblMebleg.Text = "Məbləğ:";
            // 
            // lblOdenisAdi
            // 
            this.lblOdenisAdi.AutoSize = true;
            this.lblOdenisAdi.Location = new System.Drawing.Point(6, 42);
            this.lblOdenisAdi.Name = "lblOdenisAdi";
            this.lblOdenisAdi.Size = new System.Drawing.Size(61, 13);
            this.lblOdenisAdi.TabIndex = 1;
            this.lblOdenisAdi.Text = "Ödəniş Adı:";
            // 
            // lblIsciKodu
            // 
            this.lblIsciKodu.AutoSize = true;
            this.lblIsciKodu.Location = new System.Drawing.Point(6, 13);
            this.lblIsciKodu.Name = "lblIsciKodu";
            this.lblIsciKodu.Size = new System.Drawing.Size(54, 13);
            this.lblIsciKodu.TabIndex = 0;
            this.lblIsciKodu.Text = "İşçi Kodu:";
            // 
            // tabPagestatistika
            // 
            this.tabPagestatistika.Controls.Add(this.lstStatPayments);
            this.tabPagestatistika.Controls.Add(this.lblStatInfo);
            this.tabPagestatistika.Controls.Add(this.btnSearchStat);
            this.tabPagestatistika.Controls.Add(this.txtStatCode);
            this.tabPagestatistika.Controls.Add(this.lblkod);
            this.tabPagestatistika.Location = new System.Drawing.Point(4, 22);
            this.tabPagestatistika.Name = "tabPagestatistika";
            this.tabPagestatistika.Size = new System.Drawing.Size(389, 400);
            this.tabPagestatistika.TabIndex = 2;
            this.tabPagestatistika.Text = "Statistika";
            this.tabPagestatistika.UseVisualStyleBackColor = true;
            // 
            // lstStatPayments
            // 
            this.lstStatPayments.FormattingEnabled = true;
            this.lstStatPayments.Location = new System.Drawing.Point(8, 94);
            this.lstStatPayments.Name = "lstStatPayments";
            this.lstStatPayments.Size = new System.Drawing.Size(360, 290);
            this.lstStatPayments.TabIndex = 4;
            // 
            // lblStatInfo
            // 
            this.lblStatInfo.AutoSize = true;
            this.lblStatInfo.Location = new System.Drawing.Point(5, 67);
            this.lblStatInfo.Name = "lblStatInfo";
            this.lblStatInfo.Size = new System.Drawing.Size(10, 13);
            this.lblStatInfo.TabIndex = 3;
            this.lblStatInfo.Text = "-";
            // 
            // btnSearchStat
            // 
            this.btnSearchStat.Location = new System.Drawing.Point(293, 35);
            this.btnSearchStat.Name = "btnSearchStat";
            this.btnSearchStat.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStat.TabIndex = 2;
            this.btnSearchStat.Text = "Axtar";
            this.btnSearchStat.UseVisualStyleBackColor = true;
            this.btnSearchStat.Click += new System.EventHandler(this.btnSearchStat_Click_1);
            // 
            // txtStatCode
            // 
            this.txtStatCode.Location = new System.Drawing.Point(65, 9);
            this.txtStatCode.Name = "txtStatCode";
            this.txtStatCode.Size = new System.Drawing.Size(303, 20);
            this.txtStatCode.TabIndex = 1;
            // 
            // lblkod
            // 
            this.lblkod.AutoSize = true;
            this.lblkod.Location = new System.Drawing.Point(5, 12);
            this.lblkod.Name = "lblkod";
            this.lblkod.Size = new System.Drawing.Size(54, 13);
            this.lblkod.TabIndex = 0;
            this.lblkod.Text = "İşçi Kodu:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(694, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Çıxış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageisci.ResumeLayout(false);
            this.tabPageisci.PerformLayout();
            this.tabPageodenis.ResumeLayout(false);
            this.tabPageodenis.PerformLayout();
            this.tabPagestatistika.ResumeLayout(false);
            this.tabPagestatistika.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageisci;
        private System.Windows.Forms.TabPage tabPageodenis;
        private System.Windows.Forms.Label lblyas;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lbliscikod;
        private System.Windows.Forms.TabPage tabPagestatistika;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblMebleg;
        private System.Windows.Forms.Label lblOdenisAdi;
        private System.Windows.Forms.Label lblIsciKodu;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.TextBox txtPayTitle;
        private System.Windows.Forms.TextBox txtPayCode;
        private System.Windows.Forms.TextBox txtStatCode;
        private System.Windows.Forms.Label lblkod;
        private System.Windows.Forms.ListBox lstStatPayments;
        private System.Windows.Forms.Label lblStatInfo;
        private System.Windows.Forms.Button btnSearchStat;
        private System.Windows.Forms.Button btnExit;
    }
}

