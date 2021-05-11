using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreferredCustomerPrgm
{
    public partial class Form1 : Form
    {
        string name, address, phoneNum, custNum, order;
        double purchaseAmnt = 0, discount = 0;
        bool DontMailMe, returnCustomr;
        public Form1()
        {
            InitializeComponent();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayOrder_Click(object sender, EventArgs e)
        {
            bool formComplete = CheckForm();
            if (formComplete)
            {
                try
                {
                    bool goodName, goodNumber;
                    name = nameInput.Text;
                    address = addressInput.Text;
                    phoneNum = phoneInput.Text;
                    custNum = custmrNumInput.Text;
                    order = GetOrder();
                    purchaseAmnt = GetPurchaseAmount(order);
                    goodName = VerifyName(name);
                    goodNumber = VerifyPhoneNumber(phoneNum);

                    if (!goodNumber)
                        MessageBox.Show("Error::Invalid Format phone number must be digits in ###-###-#### or ########## format only");
                    if (!goodName)
                        MessageBox.Show("Error::Names Cannot be numeric");

                    if (goodName && goodNumber)
                    {
                        Customer customer1 = new Customer(name, address, phoneNum, custNum, order);

                        MessageBox.Show("\tOrder Information : \n" +
                            "Name : " + customer1.Name + "\n" +
                            "Address : " + customer1.Address + "\n" +
                            "Phone Number : " + customer1.PhoneNumber + "\n" +
                            "Customer Number : " + customer1.CustomerNumber + "\n" +
                            "\tOrdered Items :" + customer1.Order + "\n" +
                            "\nTotal Cost : " + purchaseAmnt.ToString("c"));
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Please complete all entries on form");
        }

        private void displayCustomer_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                bool goodNumber;
                bool goodName;
                
                name = nameInput.Text;
                address = addressInput.Text;
                phoneNum = phoneInput.Text;
                custNum = custmrNumInput.Text;

                goodNumber = VerifyPhoneNumber(phoneNum);
                goodName = VerifyName(name);

                if (dontAddMail.Checked)
                    DontMailMe = true;
                else
                    DontMailMe = false;

                if(!goodNumber)
                    MessageBox.Show("Error::Invalid Format phone number must be digits in ###-###-#### or ########## format only");
                if (!goodName)
                    MessageBox.Show("Error::Names Cannot be numeric");

                if(goodNumber && goodName)
                {
                    Customer customer1 = new Customer(name, address, phoneNum, custNum);
                    customer1.OnMailList = DontMailMe;

                    MessageBox.Show("Name : " + customer1.Name + "\n" +
                        "Address : " + customer1.Address + "\n" +
                        "Phone Number : " + customer1.PhoneNumber + "\n" +
                        "Customer Number : " + customer1.CustomerNumber);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            bool completeForm = CheckForm();

            if (completeForm)
            {
                try
                {
                    bool goodName, goodNumber;
                    name = nameInput.Text;
                    address = addressInput.Text;
                    phoneNum = phoneInput.Text;
                    custNum = custmrNumInput.Text;
                    DontMailMe = dontAddMail.Checked;
                    order = GetOrder();
                    purchaseAmnt = GetPurchaseAmount(order);


                    goodName = VerifyName(name);
                    goodNumber = VerifyPhoneNumber(phoneNum);

                    if (!goodNumber)
                        MessageBox.Show("Error::Invalid Format phone number must be digits in ###-###-#### or ########## format only");
                    if (!goodName)
                        MessageBox.Show("Error::Names Cannot be numeric");

                    if (goodName && goodNumber && returnYes.Checked)
                    {
                        PreferredCustomer prefCustmer1 = new PreferredCustomer(name,address,phoneNum,custNum,purchaseAmnt,order);

                        MessageBox.Show("Your order has been placed\n\n" +
                            "Name : " + prefCustmer1.Name + "\n" +
                            "Address : " + prefCustmer1.Address + "\n" +
                            "Phone Number : " + prefCustmer1.PhoneNumber + "\n" +
                            "Customer Number : " + prefCustmer1.CustomerNumber + "\n" + "\n" +
                            "Purchase Amount : " + prefCustmer1.PurchaseAmount + "\n" +
                            "Discount Amount : " + prefCustmer1.Discount.ToString("P1")); 
                    }
                    else if (goodName && goodNumber && returnNo.Checked)
                    {
                        MessageBox.Show("Return to become a preferred customer and get additonal savings!!");
                        Customer customer1 = new Customer(name, address, phoneNum, custNum);

                        MessageBox.Show("Your order has been placed\n\n" +
                                    "Name : " + customer1.Name + "\n" +
                                    "Address : " + customer1.Address + "\n" +
                                    "Phone Number : " + customer1.PhoneNumber + "\n" +
                                    "Customer Number : " + customer1.CustomerNumber + "\n" + "\n" +
                                    "Purchase Amount : " + purchaseAmnt.ToString("c"));
                    }



                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
                MessageBox.Show("Please fill out all entries on form");
        }

        public bool CheckForm()
        {
            bool completed = true;

            if (nameInput.Text == "")
                completed = false;
            if (addressInput.Text == "")
                completed = false;
            if (phoneInput.Text == "")
                completed = false;
            if (dontAddMail.Checked == false)
                completed = false;
            if (custmrNumInput.Text == "")
                completed = false;
            if (returnYes.Checked == false && returnNo.Checked == false)
                completed = false;
            if (itemsListbox.CheckedItems.Count == 0)
                completed = false;

            return completed;
        }
        public string GetOrder()
        {
            string dirtyOrder = "";
            char [] delims = { '\n', '\t' };
            string [] cleanOrder;
            string order = null;

            for (int item = 0; item < (itemsListbox.CheckedItems.Count); item++)
            {
                dirtyOrder += "\n" + itemsListbox.CheckedItems[item].ToString();
            }
            cleanOrder = dirtyOrder.Split(delims);

            for(int item = 0; item < cleanOrder.Length; item++)
            {
                if (cleanOrder[item].StartsWith("W"))
                     order += "\n" + cleanOrder[item];
                if (cleanOrder[item].StartsWith("J"))
                    order += "\n" + cleanOrder[item];
                if (cleanOrder[item].StartsWith("N"))
                    order += "\n" + cleanOrder[item];
                if (cleanOrder[item].StartsWith("T"))
                    order += "\n" + cleanOrder[item];
                if (cleanOrder[item].StartsWith("M"))
                    order += "\n" + cleanOrder[item];
                if (cleanOrder[item].StartsWith("B"))
                    order += "\n" + cleanOrder[item];
                if (cleanOrder[item].StartsWith("A"))
                    order += "\n" + cleanOrder[item];
                if (cleanOrder[item].StartsWith("S"))
                    order += "\n" + cleanOrder[item];
                if (cleanOrder[item].StartsWith("D"))
                    order += "\n" + cleanOrder[item];
                if (cleanOrder[item].StartsWith("R"))
                    order += "\n" + cleanOrder[item];

            }
            return order;
        }
        public double GetPurchaseAmount(string items)
        {
            double purchaseAmount = 0.0;
            char delim = '\n';
            items.ToUpper();
            string[] order = items.Split(delim);

            //W150 J1100 N200 T300 M700 B650 A1500 S800 D2000 R500
            for (int item = 0; item < order.Length; item++)
            {
                if (order[item].StartsWith("W"))
                    purchaseAmount += 150.00;
                if (order[item].StartsWith("J"))
                    purchaseAmount += 1100.00;
                if (order[item].StartsWith("N"))
                    purchaseAmount += 200.00;
                if (order[item].StartsWith("T"))
                    purchaseAmount += 300.00;
                if (order[item].StartsWith("M"))
                    purchaseAmount += 700.00;
                if (order[item].StartsWith("B"))
                    purchaseAmount += 650.00;
                if (order[item].StartsWith("A"))
                    purchaseAmount += 1500.00;
                if (order[item].StartsWith("S"))
                    purchaseAmount += 800.00;
                if (order[item].StartsWith("D"))
                    purchaseAmount += 2000.00;
                if (order[item].StartsWith("R"))
                    purchaseAmount += 500.00;
            }

            return purchaseAmount;
        }
        public bool VerifyPhoneNumber(string pnumb)
        {
            int len = pnumb.Length;
            bool validNumber = true;
            char dash = '-';
            char number = ' ';

            if (len < 10 || len > 12)
                validNumber = false;
            
            for (int digit = 0; digit < len; digit++)
            {
                number = pnumb[digit];
                if (char.IsLetter(number))
                    validNumber = false;
            }

            return validNumber;
        }
        public bool VerifyName(string name)
        {
            bool validName = true;

            for(int letter = 0; letter < name.Length; letter++)
            {
                if (char.IsDigit(name[letter]))
                    validName = false;
            }

            return validName;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            itemsListbox.Items.Add("Water Rocket\t\t$150");
            itemsListbox.Items.Add("J5 Replica\t\t$1100");
            itemsListbox.Items.Add("Nightvision Glasses\t$200");
            itemsListbox.Items.Add("T-rex Suit\t\t$300");
            itemsListbox.Items.Add("Mini Tank\t\t$700");
            itemsListbox.Items.Add("Bonzi Tree Kit\t\t$650");
            itemsListbox.Items.Add("Auto Lawm-Mower\t$1500");
            itemsListbox.Items.Add("Stfluffy\t\t\t$800");
            itemsListbox.Items.Add("Dishes Robot\t\t$2000");
            itemsListbox.Items.Add("Robot Dog\t\t$500");  
        }
    }
}
