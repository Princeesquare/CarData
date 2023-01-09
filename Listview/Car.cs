using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Car : Form
    {
        public DataTable car_list = new DataTable();
        public int AutoID = 1;

        BindingList<info> Carsinfo = new BindingList<info>();

        public Car()
        {
            InitializeComponent();
        }

        private void Car_Load_1(object sender, EventArgs e)
        {
            id.Text = AutoID.ToString();
            mygrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mygrid.MultiSelect = false;
            mygrid.DataSource = Carsinfo;
            mygrid.Columns[0].Visible = false;
            mygrid.Columns[1].Visible = false;
            mygrid.Columns[2].Visible = false;
            mygrid.Columns[3].Visible = false;
            mygrid.Columns[4].Visible = false;
            mygrid.Columns[5].Visible = false;
        }

        private void customize_Click(object sender, EventArgs e) // CUSTOMIZE BUTTON
        {
            if (idBox.Checked &&
				//mygrid.Columns[0].Visible == false &&
				modelBox.Checked == false &&
				mygrid.Columns[1].Visible == false &&
				yearBox.Checked == false &&
				mygrid.Columns[2].Visible == false &&
				gearBox.Checked == false &&
				//mygrid.Columns[3].Visible == false &&
				colorBox.Checked == false &&
				//mygrid.Columns[4].Visible == false &&
				maxBox.Checked == false //&&
				//mygrid.Columns[5].Visible == false
                )
                MessageBox.Show("Please Select a Column Header and Click on Customize.");

            else
            {
                if (mygrid.Columns[0].Visible = true && idBox.Checked == false) //ID CheckBox
                {
                    MessageBox.Show("ID Column is required", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    idBox.Checked = true;
                    return;
                }
                else
                {
                    if (idBox.Checked)
                        mygrid.Columns[0].Visible = true;
                    mygrid.Columns[0].DisplayIndex = 0;
                }

                if (mygrid.Columns[1].Visible && modelBox.Checked == false) //Model CheckBox
                {
                    if (MessageBox.Show("Do you want to remove the MODEL coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        model.Enabled = false;
                        mygrid.Columns[1].Visible = false;
                    }
                    else
                    {
                        modelBox.Checked = true;
                        return;
                    }
                }
                else
                {
                    if (modelBox.Checked)
                    {
                        model.Enabled = true;
                        mygrid.Columns[1].Visible = true;
                        mygrid.Columns[1].DisplayIndex = 1;
                    }
                }

                if (mygrid.Columns[2].Visible && yearBox.Checked == false) // CheckBox
                {
                    if (MessageBox.Show("Do you want to remove the YEAR coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        year.Enabled = false;
                        mygrid.Columns[2].Visible = false;
                    }
                    else
                    {
                        yearBox.Checked = true;
                        return;
                    }
                }
                else
                {
                    if (yearBox.Checked)
                    {
                        year.Enabled = true;
                        mygrid.Columns[2].Visible = true;
                        mygrid.Columns[2].DisplayIndex = 2;
                    }
                }

                if (mygrid.Columns[3].Visible && gearBox.Checked == false) //GEAR CheckBox
                {
                    if (MessageBox.Show("Do you want to remove the GEAR coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        gear.Enabled = false;
                        mygrid.Columns[3].Visible = false;
                    }
                    else
                    {
                        gearBox.Checked = true;
                        return;
                    }
                }
                else
                {
                    if (gearBox.Checked)
                    {
                        gear.Enabled = true;
                        mygrid.Columns[3].Visible = true;
                        mygrid.Columns[3].DisplayIndex = 3;
                    }
                }
                /*
                if (mygrid.Columns[2].Visible && yearBox.Checked == false) // Year CheckBox
                {
                    if (MessageBox.Show("Do you want to remove the YEAR coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        year.Enabled = false;
                        mygrid.Columns[2].Visible = false;
                    }
                    else
                    {
                        yearBox.Checked = true;
                        return;
                    }
                }
                else
                {
                    if (mygrid.Columns[2].Visible = false && yearBox.Checked)
                    {
                        year.Enabled = true;
                        mygrid.Columns[2].Visible = true;
                    }
                }
                /*
                if (mygrid.Columns.Contains(gearbox.Text) && gearbox.Checked == false) // GearBox checkBox 
                {
                    if (MessageBox.Show("Do you want to remove the GEARBOX coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        gear.Enabled = false;
                        car_list.Columns.Remove(gearbox.Text);
                    }
                    else
                    {
                        gearbox.Checked = true;
                        return;
                    }
                }
                else
                {
                    if (mygrid.Columns.Contains(gearbox.Text) == false && gearbox.Checked)
                    {
                        gear.Enabled = true;
                        car_list.Columns.Add(gearbox.Text);
                    }
                }

                if (mygrid.Columns.Contains(colorBox.Text) && colorBox.Checked == false) // Color checkBox
                {
                    if (MessageBox.Show("Do you want to remove the COLOR coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        color.Enabled = false;
                        car_list.Columns.Remove(colorBox.Text);
                    }
                    else
                    {
                        colorBox.Checked = true;
                        return;
                    }
                }
                else
                {
                    if (mygrid.Columns.Contains(colorBox.Text) == false && colorBox.Checked)
                    {
                        color.Enabled = true;
                        car_list.Columns.Add(colorBox.Text);
                    }
                }

                if (mygrid.Columns.Contains(maxBox.Text) && maxBox.Checked == false) // Max_Speed checkBox
                {
                    if (MessageBox.Show("Do you want to remove the MAX_SPEED coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        speed.Enabled = false;
                        car_list.Columns.Remove(maxBox.Text);
                    }
                    else
                    {
                        maxBox.Checked = true;
                        return;
                    }
                }
                else
                {
                    if (mygrid.Columns.Contains(maxBox.Text) == false && maxBox.Checked)
                    {
                        speed.Enabled = true;
                        car_list.Columns.Add(maxBox.Text, typeof(int));
                    }
                }*/
            }
        }

        private void add_Click(object sender, EventArgs e)
        {

            if (mygrid.Columns.Contains(idBox.Text) == false) MessageBox.Show("Data Column Header is empty\nPlease select a columns and click CUSTOMIZE!!");

            else
            {
                if ((model.Enabled = true && model.Text == "" && modelBox.Checked) ||
                    (year.Enabled = true && year.Text == "" && yearBox.Checked) ||
                    (gear.Enabled = true && gear.Text == "" && gearBox.Checked) ||
                    (color.Enabled = true && color.Text == "" && colorBox.Checked) ||
                    (speed.Enabled = true && speed.Text == "" && maxBox.Checked))
                    MessageBox.Show("Please Fill in the required Field.");

                else if ((model.Enabled = false || modelBox.Checked == false) ||
                        (year.Enabled = false || yearBox.Checked == false) ||
                        (gear.Enabled = false || gearBox.Checked == false) ||
                        (color.Enabled = false || colorBox.Checked == false) ||
                        (speed.Enabled = false || maxBox.Checked == false))
                {
                    MessageBox.Show("Required Car Information is missing. \nPlease Select and Customize all Column Headers ");
                    model.Enabled = true; year.Enabled = true; gear.Enabled = true; color.Enabled = true; speed.Enabled = true;
                }

                else
                {

                    /*if (model.Enabled = true && model.Text == "" && modelBox.Checked)
                    {
                        errorProvider1.SetError(model, "Required Field");
                        MessageBox.Show("Please Fill in the required Field.");
                    }
                    else
                    {
                    */

                    for (int i = 0; i < Carsinfo.Count; i++)
                    {
                        if (model.Text == Carsinfo[i].Model &&
                            year.Text == (Carsinfo[i].Year).ToString() &&
                            gear.Text == Carsinfo[i].Gear &&
                            color.Text == Carsinfo[i].Color &&
                            speed.Text == Carsinfo[i].MaxSpeed.ToString())
                        {
                            MessageBox.Show("Car already Exist"); return;
                        }
                    }

                    Carsinfo.Add(new info
                    {
                        ID = AutoID,
                        Model = model.Text,
                        Year = int.Parse(year.Text),
                        Gear = gear.Text,
                        Color = color.Text,
                        MaxSpeed = int.Parse(speed.Text)
                    });
                    AutoID++;



                    //car_list.Rows.Add(ID++, model.Text, year.Text, gear.Text, color.Text, speed.Text);
                    model.Enabled = true;
                    model.Text = "";
                    year.Enabled = true;
                    year.Text = "";
                    gear.Enabled = true;
                    gear.Text = "";
                    color.Enabled = true;
                    color.Text = "";
                    speed.Enabled = true;
                    speed.Text = "";
                    id.Text = AutoID.ToString();

                    //  errorProvider1.Clear();
                    //}

                    /*if (year.Enabled = true && year.Text == "" && yearBox.Checked)
                    {
                        errorProvider1.SetError(year, "Required Field");
                        MessageBox.Show("Please Fill in the required Field.");
                    }
                    else
                    {
                    */
                    //  car_list.Rows.Add(year.Text);
                    /*  errorProvider1.Clear();
                  }

                  if (gear.Enabled = true && gear.Text == "" && gearbox.Checked)
                  {
                      errorProvider1.SetError(gear, "Required Field");
                      MessageBox.Show("Please Fill in the required Field.");
                  }
                  else
                  {
                  */
                    //car_list.Rows.Add(gear.Text);
                    /*  errorProvider1.Clear();
                  }

                  if (color.Enabled = true && color.Text == "" && colorBox.Checked)
                  {
                      errorProvider1.SetError(color, "Required Field");
                      MessageBox.Show("Please Fill in the required Field.");
                  }
                  else
                  {
                  */
                    //car_list.Rows.Add(color.Text);
                    /*  errorProvider1.Clear();
                  }

                  if (speed.Enabled = true && speed.Text == "" && maxBox.Checked)
                  {
                      errorProvider1.SetError(speed, "Required Field");
                      MessageBox.Show("Please Fill in the required Field.");
                  }
                  else
                  {
                  */
                    // car_list.Rows.Add(speed.Text);
                    //    errorProvider1.Clear();
                    //}
                    // if(model.Text = "" || year)
                    //car_list.Rows.Add(ID++);

                }
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you Sure You Want To Remove The Selected Row?", "Warning!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
             {
                 int index = int.Parse(mygrid.SelectedCells[0].Value.ToString()) - 1;
                 Carsinfo.RemoveAt(index);
                 for (int i = index; i < Carsinfo.Count; i++)
                     Carsinfo[i].ID--;
                 AutoID--;
                MessageBox.Show("Item Deleted Successfully");
            }
             else
                 return;
        }

        private void numberof_Click(object sender, EventArgs e)
        {
            if (!manual.Checked && !automatic.Checked)
                MessageBox.Show("Select a Car Gear Type.");
            else
            {
                  int cnt = 0;
                  if(manual.Checked)
                  {
                      for (int i = 0; i < Carsinfo.Count; i++)
                      {
                          if (Carsinfo[i].Gear == "Manual" || Carsinfo[i].Gear == "manual") cnt++;
                      }
                      MessageBox.Show("There are " + cnt + "number of Manual Cars");
                  }
                  else
                  {
                      for (int i = 0; i < Carsinfo.Count; i++)
                      {
                          if (Carsinfo[i].Gear == "Automatic" || Carsinfo[i].Gear == "automatic") cnt++;
                      }
                      MessageBox.Show("There are " + cnt + "number of Automatic Cars");
                  }
            }
        }

        private void year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Digits");
            }
        }

        private void speed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Digits");
            }
        }

        private void fastest_Click(object sender, EventArgs e)
        {
             int Max = 0;
             for (int i = 0; i < Carsinfo.Count; i++)
             {
                if (Max > Carsinfo[i].MaxSpeed)
                 {
                     Max = i;
                     MessageBox.Show("The Fastest Car is: " + Carsinfo[i].Model + " at a speed of " + Max + "km/h");
                 }
             }
             
        }

        private void mygrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = mygrid.SelectedCells[0].Value.ToString();
            model.Text = mygrid.SelectedCells[1].Value.ToString();
            year.Text = mygrid.SelectedCells[2].Value.ToString();
            gear.Text = mygrid.SelectedCells[3].Value.ToString();
            color.Text = mygrid.SelectedCells[4].Value.ToString();
            speed.Text = mygrid.SelectedCells[5].Value.ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.Text == "Select")
                MessageBox.Show("Please Select a Brand");
            else
            {
                if (comboBox1.Text == "BMW")
                    System.Diagnostics.Process.Start("https://www.bmw.com.cy/en/all-models.html?tl=grp-wdpl-bcom-mix-mn-.-nscf-.-.-");
                if (comboBox1.Text == "Benz")
                    System.Diagnostics.Process.Start("https://www.mbusa.com/en/all-vehicles");
                if (comboBox1.Text == "Bentley")
                    System.Diagnostics.Process.Start("https://www.bentleymotors.com/en/models.html");
                if (comboBox1.Text == "Porsche")
                    System.Diagnostics.Process.Start("https://www.porsche.com/central-eastern-europe/en/_cyprus_/models");
                if (comboBox1.Text == "Ferrari")
                    System.Diagnostics.Process.Start("https://www.ferrari.com/en-CY/auto/car-range");

                comboBox1.Text = "Select";
            }
        }
    }
}