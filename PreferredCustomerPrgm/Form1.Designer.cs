
namespace PreferredCustomerPrgm
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.custmrNumInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.displayCustomer = new System.Windows.Forms.Button();
            this.dontAddMail = new System.Windows.Forms.RadioButton();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.displayOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.returnNo = new System.Windows.Forms.RadioButton();
            this.returnYes = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(133, 34);
            this.nameInput.Multiline = true;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(183, 27);
            this.nameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.custmrNumInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.displayCustomer);
            this.groupBox1.Controls.Add(this.dontAddMail);
            this.groupBox1.Controls.Add(this.phoneInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addressInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(76, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 311);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // custmrNumInput
            // 
            this.custmrNumInput.Location = new System.Drawing.Point(10, 265);
            this.custmrNumInput.Name = "custmrNumInput";
            this.custmrNumInput.Size = new System.Drawing.Size(132, 26);
            this.custmrNumInput.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer Number:";
            // 
            // displayCustomer
            // 
            this.displayCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCustomer.Location = new System.Drawing.Point(245, 235);
            this.displayCustomer.Name = "displayCustomer";
            this.displayCustomer.Size = new System.Drawing.Size(75, 27);
            this.displayCustomer.TabIndex = 7;
            this.displayCustomer.Text = "Display";
            this.displayCustomer.UseVisualStyleBackColor = true;
            this.displayCustomer.Click += new System.EventHandler(this.displayCustomer_Click);
            // 
            // dontAddMail
            // 
            this.dontAddMail.AutoSize = true;
            this.dontAddMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dontAddMail.Location = new System.Drawing.Point(135, 201);
            this.dontAddMail.Name = "dontAddMail";
            this.dontAddMail.Size = new System.Drawing.Size(185, 20);
            this.dontAddMail.TabIndex = 6;
            this.dontAddMail.TabStop = true;
            this.dontAddMail.Text = "Don\'t add me to mailing list";
            this.dontAddMail.UseVisualStyleBackColor = true;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(135, 168);
            this.phoneInput.Multiline = true;
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(183, 27);
            this.phoneInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number:";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(133, 82);
            this.addressInput.Multiline = true;
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(183, 59);
            this.addressInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.placeOrderBtn);
            this.groupBox2.Controls.Add(this.exit);
            this.groupBox2.Controls.Add(this.displayOrder);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.itemsListbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.returnNo);
            this.groupBox2.Controls.Add(this.returnYes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(76, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(241, 172);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 33);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // displayOrder
            // 
            this.displayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayOrder.Location = new System.Drawing.Point(31, 172);
            this.displayOrder.Name = "displayOrder";
            this.displayOrder.Size = new System.Drawing.Size(75, 33);
            this.displayOrder.TabIndex = 5;
            this.displayOrder.Text = "Display";
            this.displayOrder.UseVisualStyleBackColor = true;
            this.displayOrder.Click += new System.EventHandler(this.displayOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Select Item(s):";
            // 
            // itemsListbox
            // 
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.Location = new System.Drawing.Point(31, 99);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(285, 67);
            this.itemsListbox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Are you a return customer:";
            // 
            // returnNo
            // 
            this.returnNo.AutoSize = true;
            this.returnNo.Location = new System.Drawing.Point(285, 36);
            this.returnNo.Name = "returnNo";
            this.returnNo.Size = new System.Drawing.Size(45, 24);
            this.returnNo.TabIndex = 1;
            this.returnNo.TabStop = true;
            this.returnNo.Text = "no";
            this.returnNo.UseVisualStyleBackColor = true;
            // 
            // returnYes
            // 
            this.returnYes.AutoSize = true;
            this.returnYes.Location = new System.Drawing.Point(228, 36);
            this.returnYes.Name = "returnYes";
            this.returnYes.Size = new System.Drawing.Size(51, 24);
            this.returnYes.TabIndex = 0;
            this.returnYes.TabStop = true;
            this.returnYes.Text = "yes";
            this.returnYes.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(76, 586);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Place Order";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(305, 586);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Location = new System.Drawing.Point(112, 176);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(123, 29);
            this.placeOrderBtn.TabIndex = 7;
            this.placeOrderBtn.Text = "Place Order";
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 587);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox custmrNumInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button displayCustomer;
        private System.Windows.Forms.RadioButton dontAddMail;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton returnNo;
        private System.Windows.Forms.RadioButton returnYes;
        private System.Windows.Forms.CheckedListBox itemsListbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button displayOrder;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button placeOrderBtn;
    }
}

