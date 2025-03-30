using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_project
{
    public partial class Form1 : Form
    {

 
        public Form1()
        {
            InitializeComponent();
           
            gb_size.BackColor=Color.Transparent;
            gb_Toppings.BackColor = Color.Transparent;
            gb_wheretoeat.BackColor = Color.Transparent;
            gb__CrustType.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
             

        }




        void UpdateSize()
        {
            TotalPrrice();

            if (rbsmall.Checked)
            {
                lbSize.Text = "Small";

                return;
            }
            if (rbmedium.Checked)
            {
                lbSize.Text = "Medium";
                return;
            }
            if (rbLarge.Checked)
            {

                lbSize.Text = "Large";
                return;
            }
        }

        void UpdateCrustType() {

            TotalPrrice();

            if (rbthin.Checked)
            {
                lbCrust_type.Text = "Thin";
                return ;
            }

            if (rbthick.Checked) {
                lbCrust_type.Text = "Thick";
                return ;
            }
        }

        void WhereToEat() {

            TotalPrrice();

            if (rbEatin.Checked) {
                lbWheretoeat.Text = "Eat In";
                return;
            }
            if (rbTakeout.Checked)
            {
                lbWheretoeat.Text = "Take Out";
                return;
            }
        }

       void Toppings()
        {


            TotalPrrice();


            string Toppings = ""; 
            if (cbcheese.Checked)
            {
                Toppings += "-Extra Cheese\n";
                 
            }
             if (chOliives.Checked)
            {
                Toppings += "-Olives\n";
            }
             if (chMushrooms.Checked)
            {
                Toppings += "-Mushrooms\n";
            }
             if (chOnion.Checked)
            {
                Toppings += "-Onions\n";
            }
             if (chTomatoes.Checked)
            {
                Toppings += "-Tomatoes\n";
            }
             if (chGreen_peppers.Checked) {
                Toppings += "-Green peppers\n";
            }
            if (Toppings == "") {
                Toppings = "No Toppings";
            }
             lbToppings.Text=Toppings;
         }


        float sizePrice() { 
            
            float SPrice = 0;
            if (rbsmall.Checked) { SPrice += Convert.ToSingle(rbsmall.Tag) ; }
            if ( rbmedium.Checked) { SPrice += Convert.ToSingle(rbmedium.Tag); }
            if (rbLarge.Checked) { SPrice += Convert.ToSingle(rbLarge.Tag); }

            return SPrice;

        }

        float CrustPrice() { 
        
            float CPrice=0;
            if (rbthick.Checked) { CPrice += Convert.ToSingle(rbthick.Tag); }

            return CPrice;
        }


        
        float PriceWhereToEaT() { 
        
            float WherePrice = 0;

            if (rbEatin.Checked) { WherePrice += Convert.ToSingle(rbEatin.Tag); }
            return WherePrice;
        }


        float PriceToppings() { 
            
            float PToppings = 0;

            if (cbcheese.Checked) { PToppings += Convert.ToSingle(cbcheese.Tag); }
            if (chOliives.Checked) { PToppings += Convert.ToSingle(chOliives.Tag); }
            if (chMushrooms.Checked) { PToppings += Convert.ToSingle(chMushrooms.Tag); }
            if (chOnion.Checked) { PToppings += Convert.ToSingle(chOnion.Tag); }
            if (chTomatoes.Checked) { PToppings += Convert.ToSingle(chTomatoes.Tag); }
            if (chGreen_peppers.Checked) { PToppings += Convert.ToSingle(chGreen_peppers.Tag); }

            return PToppings;


        }





        float TotalPrrice() {

            lbPrice.Text = Convert.ToString(sizePrice() +  CrustPrice() + PriceWhereToEaT() + PriceToppings()) +" $" ;
            return (sizePrice() + CrustPrice() + PriceWhereToEaT() + PriceToppings());
        }


        private void btn_Order_Click(object sender, EventArgs e)
        {
          


            if (MessageBox.Show("Are you Sure ?", "Order",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                gb_Toppings.Enabled = false;
                gb__CrustType.Enabled = false;
                gb_size.Enabled = false;
                gb_wheretoeat.Enabled = false;
            }
            else
            {
                gb_Toppings.Enabled = true;
                gb__CrustType.Enabled = true;
                gb_size.Enabled = true;
                gb_wheretoeat.Enabled = true;
            }
            }

        private void rbsmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
            

        }

        private void rbmedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
          

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
            
        }

        private void rbthin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
         
        }

        private void rbthick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
           
        }

        private void rbEatin_CheckedChanged(object sender, EventArgs e)
        {
            WhereToEat();
           
        }

        private void rbTakeout_CheckedChanged(object sender, EventArgs e)
        {
            WhereToEat();
         
        }


        private void cbcheese_CheckedChanged_1(object sender, EventArgs e)
        {
            Toppings();
          
        }
        private void chMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            Toppings();
             
        }

        private void chOliives_CheckedChanged(object sender, EventArgs e)
        {
            Toppings();
             

        }

        private void chOnion_CheckedChanged(object sender, EventArgs e)
        {
            Toppings();
           

        }

        private void chGreen_peppers_CheckedChanged(object sender, EventArgs e)
        {
            Toppings();
            

        }

        private void chTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            Toppings();
            

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            
            gb_Toppings.Enabled = true;
            gb__CrustType.Enabled = true;
            gb_size.Enabled = true;
            gb_wheretoeat.Enabled = true;

        

            rbmedium.Checked=true;
            

            
            rbthin.Checked=true;
            
            rbTakeout.Checked=true;

            cbcheese.Checked=true;
            
            chOliives.Checked=false;
            chMushrooms.Checked=false;
            chOnion.Checked=false;
            chTomatoes.Checked=false;
            chGreen_peppers.Checked=false;  
        }

      
    }        
}
