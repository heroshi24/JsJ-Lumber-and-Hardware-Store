using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsJ_Lumber_and_Hardware_Store.Finaloutput
{
    public partial class frm_items : Form
    {
        public frm_items()
        {
            InitializeComponent();
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to exit the system", "Fast Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        //Reset text boxes
        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                        
                    else
                        func(control.Controls);
                string lbl6 = label6.Text = "Total Price: 0";
                string lbl5 = label5.Text = "Total Item: 0";
                string lbl8 = label8.Text = "Change: 0";
                button3.Enabled = false;
            };
            func(Controls);

        }



        private void button1_Click(object sender, EventArgs e)
        {
        RestTextBoxes();
        }

        
        //TOTAL PRICE
        private void button3_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[40];
            double[] item = new double[40];
            itemcost[0] = Convert.ToDouble(textBox1.Text) * 500;
            itemcost[1] = Convert.ToDouble(textBox2.Text) * 350;
            itemcost[2] = Convert.ToDouble(textBox3.Text) * 50;
            itemcost[3] = Convert.ToDouble(textBox4.Text) * 299;
            itemcost[4] = Convert.ToDouble(textBox5.Text) * 339;
            itemcost[5] = Convert.ToDouble(textBox6.Text) * 170;
            itemcost[6] = Convert.ToDouble(textBox7.Text) * 199;
            itemcost[7] = Convert.ToDouble(textBox8.Text) * 300;
            itemcost[8] = Convert.ToDouble(textBox9.Text) * 129;
            itemcost[9] = Convert.ToDouble(textBox10.Text) * 300;
            itemcost[10] = Convert.ToDouble(textBox11.Text) * 30;
            itemcost[11] = Convert.ToDouble(textBox12.Text) * 259;
            itemcost[12] = Convert.ToDouble(textBox13.Text) * 899;
            itemcost[13] = Convert.ToDouble(textBox14.Text) * 2500;
            itemcost[14] = Convert.ToDouble(textBox15.Text) * 6000;
            itemcost[15] = Convert.ToDouble(textBox16.Text) * 749;
            itemcost[16] = Convert.ToDouble(textBox17.Text) * 100;
            itemcost[17] = Convert.ToDouble(textBox18.Text) * 35;
            itemcost[18] = Convert.ToDouble(textBox19.Text) * 309;
            itemcost[19] = Convert.ToDouble(textBox20.Text) * 309;
            itemcost[20] = Convert.ToDouble(textBox21.Text) * 350;
            itemcost[21] = Convert.ToDouble(textBox22.Text) * 390;
            itemcost[22] = Convert.ToDouble(textBox23.Text) * 309;
            itemcost[23] = Convert.ToDouble(textBox24.Text) * 499;
            itemcost[24] = Convert.ToDouble(textBox25.Text) * 309;
            itemcost[25] = Convert.ToDouble(textBox26.Text) * 309;
            itemcost[26] = Convert.ToDouble(textBox27.Text) * 349;
            itemcost[27] = Convert.ToDouble(textBox28.Text) * 309;
            itemcost[28] = Convert.ToDouble(textBox29.Text) * 349;
            itemcost[29] = Convert.ToDouble(textBox30.Text) * 600;
            itemcost[30] = Convert.ToDouble(textBox31.Text) * 509;
            itemcost[31] = Convert.ToDouble(textBox32.Text) * 309;
            itemcost[32] = Convert.ToDouble(textBox33.Text) * 309;
            itemcost[33] = Convert.ToDouble(textBox34.Text) * 40;
            itemcost[34] = Convert.ToDouble(textBox35.Text) * 45;
            itemcost[35] = Convert.ToDouble(textBox36.Text) * 50;
            itemcost[36] = Convert.ToDouble(textBox37.Text) * 65;
            itemcost[37] = Convert.ToDouble(textBox38.Text) * 70;
            itemcost[38] = Convert.ToDouble(textBox39.Text) * 75;
            itemcost[39] = Convert.ToDouble(textBox40.Text) * 78;
            //Total Items
            item[0] = Convert.ToDouble(textBox1.Text);
            item[1] = Convert.ToDouble(textBox2.Text);
            item[2] = Convert.ToDouble(textBox3.Text);
            item[3] = Convert.ToDouble(textBox4.Text);
            item[4] = Convert.ToDouble(textBox5.Text);
            item[5] = Convert.ToDouble(textBox6.Text);
            item[6] = Convert.ToDouble(textBox7.Text);
            item[7] = Convert.ToDouble(textBox8.Text);
            item[8] = Convert.ToDouble(textBox9.Text);
            item[9] = Convert.ToDouble(textBox10.Text);
            item[10] = Convert.ToDouble(textBox11.Text);
            item[11] = Convert.ToDouble(textBox12.Text);
            item[12] = Convert.ToDouble(textBox13.Text);
            item[13] = Convert.ToDouble(textBox14.Text);
            item[14] = Convert.ToDouble(textBox15.Text);
            item[15] = Convert.ToDouble(textBox16.Text);
            item[16] = Convert.ToDouble(textBox17.Text);
            item[17] = Convert.ToDouble(textBox18.Text);
            item[18] = Convert.ToDouble(textBox19.Text);
            item[19] = Convert.ToDouble(textBox20.Text);
            item[20] = Convert.ToDouble(textBox21.Text);
            item[21] = Convert.ToDouble(textBox22.Text);
            item[22] = Convert.ToDouble(textBox23.Text);
            item[23] = Convert.ToDouble(textBox24.Text); 
            item[24] = Convert.ToDouble(textBox25.Text); 
            item[25] = Convert.ToDouble(textBox26.Text); 
            item[26] = Convert.ToDouble(textBox27.Text);
            item[27] = Convert.ToDouble(textBox28.Text);
            item[28] = Convert.ToDouble(textBox29.Text);
            item[29] = Convert.ToDouble(textBox30.Text);
            item[30] = Convert.ToDouble(textBox31.Text);
            item[31] = Convert.ToDouble(textBox32.Text);
            item[32] = Convert.ToDouble(textBox33.Text);
            item[33] = Convert.ToDouble(textBox34.Text);
            item[34] = Convert.ToDouble(textBox35.Text);
            item[35] = Convert.ToDouble(textBox36.Text);
            item[36] = Convert.ToDouble(textBox37.Text);
            item[37] = Convert.ToDouble(textBox38.Text);
            item[38] = Convert.ToDouble(textBox39.Text);
            item[39] = Convert.ToDouble(textBox40.Text);

            //COMPUTATION OF TOTAL PRICES
            double total = 0, payment, cost;

            for (int i = 0; i < itemcost.Length; i++)
            {
                total += itemcost[i];
            }
            label6.Text = Convert.ToString("Total Price:$" + total);

            double total2 = 0, payment1, cost1;

            //COMPUTATION OF TOTAL ITEM
            for (int i = 0; i < item.Length; i++)
            {
                total2 += item[i];
            }
            label5.Text = Convert.ToString("Total Item:" + total2);

            //COMPUTATION OF CHANGE
            double a = Convert.ToDouble(textBox41.Text);

            double b = a - total;

            label8.Text = Convert.ToString("Change:$" + b);

            

        }

        private void frm_items_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            //ENABLE\DISABLE PAYMENT BUTTON
            if (textBox41.Text != "")
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
        }
    }
}
//END






