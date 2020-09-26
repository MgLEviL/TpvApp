using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TpvApp
{
    public partial class Tpvform_init : Form
    {
        public bool admin = false;
        public int num_order = 1;
        float total;
        String sitio;
        String msnPay;

        Patatas ptB;
        Patatas ptM;
        Patatas ptS;
        Bebida beB;
        Bebida beM;
        Bebida beS;
        Hamburgesa hbB;
        Hamburgesa hbM;
        Hamburgesa hbS;
        Postre tarta;
        Postre cafe;
        Postre helado;
        Menu menB;
        Menu menM;
        Menu menS;


        public Tpvform_init()
        {
            InitializeComponent();
    
            labelNumpedido.Text = num_order.ToString();
            msnPay = "Añade algo a la cesta";

            menB = new Menu("M.Grande", 14.99f, 800, "Glúten, Mostaza");
            menM = new Menu("M.Mediano", 10f, 300, "Glúten, Mostaza");
            menS = new Menu("M.Pequeño", 7.99f, 100, "Glúten, Mostaza");

            ptB = new Patatas("P.Grande", 4.99f, 1000, "Glúten");
            ptM = new Patatas("P.Mediana", 3.99f, 1000, "Glúten");
            ptS = new Patatas("P.Pequeña", 2.99f, 1000, "Glúten");

            hbB = new Hamburgesa("H.Grande", 8.99f, 2000, "Glúten, Mostaza");
            hbM = new Hamburgesa("H.Mediana", 6.99f, 3000, "Glúten, Mostaza");
            hbS = new Hamburgesa("H.Pequeña", 3.99f, 3000, "Glúten, Mostaza");

            beB = new Bebida("R.Grande", 4.50f, 1000, "");
            beM = new Bebida("R.Mediano", 3.20f, 500, "");
            beS = new Bebida("R.Pequeño", 2.10f, 2000, "");

            tarta = new Postre("Tarta", 5.50f, 600, "Lacteos");
            cafe = new Postre("Café", 2.30f, 2200, "Lacteos");
            helado = new Postre("Helado", 4.30f, 140, "Lacteos, Glúten");

            radioButtonLocal.Focus();
            this.sitio = radioButtonLocal.Text.ToString();
            labelCategoria.Text = "Categoria Principal";

        }

        public void checkAdmin(bool admin) {
            if (admin)
            {
                this.admin = admin;
            }
        }

        private void button_init_Click(object sender, EventArgs e)
        {
            //button_init.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_help_Click(object sender, EventArgs e)
        {
            if (!admin)
            {
                HelpUser hp = new HelpUser();
                hp.Show();
            }
            else
            {
                String filename = Path.Combine(Application.StartupPath, "help-doc.pdf");

                if (File.Exists(filename))
                {
                    Process.Start(filename);
                }
            }
        }



        private void buttonLogin(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            if (admin)
            {
                MessageBox.Show("Sesion cerrada");
                fl.Hide();
                admin = false;
                this.flowLayoutPanelDiscounts.Hide();
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            else
            {     
                //this.Hide();
                fl.Show();
                admin = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                this.flowLayoutPanelDiscounts.Show();
            }
        }

        private void buttonHambur_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanelMain.Hide();
            labelCategoria.Text = "Elige Tamaño de Hamburgesa";
            flowLayoutHamburgesas.Show();
            this.groupBoxOperations.Show();

            this.buttonBurgerBig.Text = this.hbB.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.hbB.precio.ToString() + "€";
            this.buttonBurgerMe.Text = this.hbM.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.hbM.precio.ToString() + "€";
            this.buttonBurgerSmall.Text = this.hbS.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.hbS.precio.ToString() + "€";

            this.labelGluten.Show();
            this.labelMostaza.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.flowLayoutHamburgesas.Hide();
            labelCategoria.Text = "Categoria Principal";
            this.flowLayoutPanelMain.Show();

            this.labelGluten.Hide();
            this.labelMostaza.Hide();
        }

        private void buttonBackPatata_Click(object sender, EventArgs e)
        {
            this.flowLayoutPatatas.Hide();
            labelCategoria.Text = "Categoria Principal";
            this.flowLayoutPanelMain.Show();

            this.labelGluten.Hide();

        }

        private void buttonPatatas_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanelMain.Hide();
            labelCategoria.Text = "Elige Tamaño de Patatas";
            flowLayoutPatatas.Show();
            this.groupBoxOperations.Show();

            this.buttonPatBig.Text = this.ptB.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.ptB.precio.ToString() + "€";
            this.buttonPatMen.Text = this.ptM.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.ptM.precio.ToString() + "€";
            this.buttonPataSmall.Text = this.ptS.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.ptS.precio.ToString() + "€";

            this.labelGluten.Show();
        }

        private void buttonBackRefres_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanelRefresco.Hide();
            labelCategoria.Text = "Categoria Principal";
            this.flowLayoutPanelMain.Show();
        }

        private void buttonRefrescos_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanelMain.Hide();
            labelCategoria.Text = "Elige Tamaño de Resfresco";
            flowLayoutPanelRefresco.Show();
            this.groupBoxOperations.Show();

            this.buttonRefresBig.Text = this.beB.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.beB.precio.ToString() + "€";
            this.buttonResfresMen.Text = this.beM.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.beM.precio.ToString() + "€";
            this.buttonResfresSmall.Text = this.beS.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.beS.precio.ToString() + "€";
        }

        private void buttonMenus_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanelMain.Hide();
            labelCategoria.Text = "Elige Tamaño del Menu";
            flowLayoutPanelMenus.Show();
            this.groupBoxOperations.Show();

            this.buttonMenuBig.Text = this.menB.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.menB.precio.ToString() + "€";
            this.buttonMenuMen.Text = this.menM.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.menM.precio.ToString() + "€";
            this.buttonMenuSmall.Text = this.menS.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.menS.precio.ToString() + "€";

            this.labelGluten.Show();
            this.labelMostaza.Show();
        }

        private void buttonBackMenu_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanelMenus.Hide();
            labelCategoria.Text = "Categoria Principal";
            this.flowLayoutPanelMain.Show();

            this.labelGluten.Hide();
            this.labelMostaza.Hide();
        }

        private void buttonPostres_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanelMain.Hide();
            labelCategoria.Text = "Elige Postre";
            flowLayoutPanelPostre.Show();
            this.groupBoxOperations.Show();

            this.buttonTarta.Text = this.tarta.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.tarta.precio.ToString() + "€";
            this.buttonCafe.Text = this.cafe.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.cafe.precio.ToString() + "€";
            this.buttonHelado.Text = this.helado.nombre + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + this.helado.precio.ToString() + "€";

            this.labelLacteos.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanelPostre.Hide();
            labelCategoria.Text = "Categoria Principal";
            this.flowLayoutPanelMain.Show();

            this.labelLacteos.Hide();
        }


        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (listBoxCesta.Items.Count == 0)
            {
                MessageBox.Show(msnPay);
            }
            else
            {
          
                calcTotal();
                MessageBox.Show("Su pedido Nº: " + num_order + "\n\n- Lugar: " + this.sitio + "\n- Precio Total: " + this.total + " €" +
                    "\n\nSe ha realizado satisfactoriamente\nGracias por su pedido. Y buen provecho");
                this.total = 0;
                this.num_order += 1;
                this.labelNumpedido.Text = num_order.ToString();
                labelTotal.Text = "0 €";
                listBoxCesta.Items.Clear();
                buttonApplyDiscount.Enabled = true;

                FormInitOrtder order = new FormInitOrtder();
                order.Show();
            }          
        }

        private void calcTotal()
        {
            total = 0;
            foreach (object item in listBoxCesta.Items)
            {
                this.total += float.Parse(item.ToString().Substring(item.ToString().Length - 5));
                this.labelTotal.Text = this.total.ToString("####0.00") + " €";
            }
        }


        private void buttonBurgerBig_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(hbB.nombre + "\t\t\t\t" + hbB.precio);
            this.hbB.cantidad += 1;
            calcTotal();
        }

        private void buttonBurgerMe_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(hbM.nombre + "\t\t\t" + hbM.precio);
            this.hbM.cantidad += 1;
            calcTotal();
        }

        private void buttonBurgerSmall_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(hbS.nombre + "\t\t\t" + hbS.precio);
            this.hbS.cantidad += 1;
            calcTotal();
        }

        private void buttonRefresBig_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(beB.nombre + "\t\t\t\t" + beB.precio);
            this.beB.cantidad += 1;
            calcTotal();
        }

        private void buttonResfresMen_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(beM.nombre + "\t\t\t" + beM.precio);
            this.beM.cantidad += 1;
            calcTotal();
        }

        private void buttonResfresSmall_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(beS.nombre + "\t\t\t" + beS.precio);
            this.beS.cantidad += 1;
            calcTotal();
        }

        private void buttonPatBig_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(ptB.nombre + "\t\t\t\t" + ptB.precio);
            this.ptB.cantidad += 1;
            calcTotal();
        }

        private void buttonPatMen_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(ptM.nombre + "\t\t\t" + ptM.precio);
            this.ptM.cantidad += 1;
            calcTotal();
        }

        private void buttonPataSmall_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(ptS.nombre + "\t\t\t" + ptS.precio);
            this.ptS.cantidad += 1;
            calcTotal();
        }

        private void buttonMenuBig_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(menB.nombre + "\t\t\t" + menB.precio);
            this.menB.cantidad += 1;
            calcTotal();
        }

        private void buttonMenuMen_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(menM.nombre + "\t\t\t" + menM.precio);
            this.menM.cantidad += 1;
            calcTotal();
        }

        private void buttonMenuSmall_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(menS.nombre + "\t\t\t" + menS.precio);
            this.menS.cantidad += 1;
            calcTotal();
        }

        private void buttonCafe_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(cafe.nombre + "\t\t\t\t" + cafe.precio);
            this.cafe.cantidad += 1;
            calcTotal();
        }

        private void buttonHelado_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(helado.nombre + "\t\t\t\t" + helado.precio);
            this.helado.cantidad += 1;
            calcTotal();
        }

        private void buttonTarta_Click(object sender, EventArgs e)
        {
            listBoxCesta.Items.Add(tarta.nombre + "\t\t\t\t" + tarta.precio);
            this.tarta.cantidad += 1;
            calcTotal();
        }

        private void buttonSumProd_Click(object sender, EventArgs e)
        {
            try
            {
                String seleccionado = listBoxCesta.SelectedItem.ToString();
                listBoxCesta.Items.Add(seleccionado);
                calcTotal();
            }
            catch (System.NullReferenceException ex)
            {
                ex.ToString();
            }

        }

        private void buttonRestarProd_Click(object sender, EventArgs e)
        {
            try
            {
                String seleccionado = listBoxCesta.SelectedItem.ToString();
                listBoxCesta.Items.Remove(seleccionado);
                calcTotal();
                if (listBoxCesta.Items.Count == 0) labelTotal.Text = "0 €";
            }
            catch (System.NullReferenceException ex)
            {
                ex.ToString();
            }

        }

        private void radioButtonLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLocal.Focused) this.sitio = radioButtonLocal.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Focused) this.sitio = radioButton2.Text.ToString();
        }

        private void buttonDiscount_Click(object sender, EventArgs e)
        {
            labelCategoria.Text = buttonDiscount.Text;
            flowLayoutPanelDiscounts.Show();
            if(!admin)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
        }

        private void buttonApplyDiscount_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int cont2 = 0;
            String msgDiscount = "No hay descuentos disponibles";

            if (checkBox1.Checked || checkBox2.Checked)
            {
                //Primera oferta
                foreach (object item in listBoxCesta.Items)
                {
                    if(item.ToString().Substring(0, 8).Equals(hbB.nombre))
                    {
                        cont++;
                    }
                }

                if(cont % 2 == 0 || cont >= 2)
                {
                    for (int i = 2; i <= cont; i += 2)
                    {
                        listBoxCesta.Items.Add(beM.nombre + "\t\t\t" + "0.00");
                    }
                }
                
                //Segunda oferta   
                foreach (object item in listBoxCesta.Items)
                {
                    if (item.ToString().Substring(0, 8).Equals(ptB.nombre))
                    {
                        cont2++;
                    }
                }

                if (cont2 % 2 == 0 || cont >= 2)
                {
                    for (int i = 2; i <= cont2; i += 2)
                    {
                        listBoxCesta.Items.Add(beS.nombre + "\t\t\t" + "0.00");
                    }
                }
                buttonApplyDiscount.Enabled = false;
            }
            else
            {
                MessageBox.Show(msgDiscount);
            }
        }

        private void buttonBackDiscounts_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanelDiscounts.Hide();
            labelCategoria.Text = "Categoria Principal";
            this.flowLayoutPanelMain.Show();
        }
    }
}
