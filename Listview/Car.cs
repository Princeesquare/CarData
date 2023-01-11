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
        // FORM LOAD //
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

        // CUSTOMIZE BUTTON  //
        private void customize_Click(object sender, EventArgs e)
        {
            if (idBox.Checked &&
                modelBox.Checked == false &&
                yearBox.Checked == false &&
                gearBox.Checked == false &&
                colorBox.Checked == false &&
                maxBox.Checked == false)
                MessageBox.Show("Please Select a Column Header and Click on Customize.");

            else
            {
                if (mygrid.Columns[0].Visible = true && idBox.Checked == false) //ID CheckBox HANDLING
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

                if (mygrid.Columns[1].Visible && modelBox.Checked == false) //MODEL CheckBox HANDLING
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

                if (mygrid.Columns[2].Visible && yearBox.Checked == false) //YEAR CheckBox HANDLING
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

                if (mygrid.Columns[3].Visible && gearBox.Checked == false) //GEAR CheckBox HANDLING 
                {
                    if (MessageBox.Show("Do you want to remove the GEAR coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        gearcombobox.Enabled = false;
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
                        gearcombobox.Enabled = true;
                        mygrid.Columns[3].Visible = true;
                        mygrid.Columns[3].DisplayIndex = 3;
                    }
                }

                if (mygrid.Columns[4].Visible && colorBox.Checked == false) //COLOR CheckBox HANDLING
                {
                    if (MessageBox.Show("Do you want to remove the COLOR coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        color.Enabled = false;
                        mygrid.Columns[4].Visible = false;
                    }
                    else
                    {
                        colorBox.Checked = true;
                        return;
                    }
                }
                else
                {
                    if (colorBox.Checked)
                    {
                        color.Enabled = true;
                        mygrid.Columns[4].Visible = true;
                        mygrid.Columns[4].DisplayIndex = 4;
                    }
                }

                if (mygrid.Columns[5].Visible && maxBox.Checked == false) //MAX_SPEED CheckBox HANDLING
                {
                    if (MessageBox.Show("Do you want to remove the GEAR coulmn?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        speed.Enabled = false;
                        mygrid.Columns[5].Visible = false;
                    }
                    else
                    {
                        maxBox.Checked = true;
                        return;
                    }
                }
                else
                {
                    if (maxBox.Checked)
                    {
                        speed.Enabled = true;
                        mygrid.Columns[5].Visible = true;
                        mygrid.Columns[5].DisplayIndex = 5;
                    }
                }                
            }
        }

        // ADD BUTTON //
        private void add_Click(object sender, EventArgs e)
        {

            if (mygrid.Columns[0].Visible == false)
                MessageBox.Show("Data Column Header is empty\nPlease select a columns and click CUSTOMIZE!!");
            
            else
            {
                for (int i = 0; i < Carsinfo.Count; i++)
                    if (model.Text == Carsinfo[i].Model &&
                        year.Text == Carsinfo[i].Year &&
                        gearcombobox.Text == Carsinfo[i].Gear &&
                        color.Text == Carsinfo[i].Color &&
                        speed.Text == Carsinfo[i].MaxSpeed)
                    {
                        MessageBox.Show("Car Already Exists");
                        return;
                    }
                if (year.Enabled == false)
                    MessageBox.Show("Car Year Column is Required\nPlease Add Year Column to Continue");
                else
                {
                    if ((model.Enabled = true && model.Text == "" && modelBox.Checked) ||
                                (year.Enabled = true && year.Text == "" && yearBox.Checked) ||
                                (gearcombobox.Enabled = true && gearcombobox.Text == "Select" && gearBox.Checked) ||
                                (color.Enabled = true && color.Text == "" && colorBox.Checked) ||
                                (speed.Enabled = true && speed.Text == "" && maxBox.Checked))
                        MessageBox.Show("Please Fill All Open Fields.");
                    else
                    {
                        if (int.Parse(year.Text) >= 1900 && int.Parse(year.Text) <= DateTime.Now.Year && 
                            int.Parse(speed.Text) >= 10 && int.Parse(speed.Text) <= 500)
                        {
                            Carsinfo.Add(new info
                            {
                                ID = AutoID,
                                Model = model.Text,
                                Year = year.Text,
                                Gear = gearcombobox.Text,
                                Color = color.Text,
                                MaxSpeed = speed.Text
                            });
                            AutoID++;
                            model.Text = "";
                            year.Text = "";
                            gearcombobox.Text = "Select";
                            color.Text = "";
                            speed.Text = "";
                            model.Enabled = true;
                            year.Enabled = true; speed.Enabled = true;
                            gearcombobox.Enabled = true; color.Enabled = true;
                            id.Text = AutoID.ToString();
                        }
                        else
                            MessageBox.Show("Car Year should not be less than 1900 or Greater than " + DateTime.Now.Year +
                               "\nMax_Speed should not be less than 10Km/hr or greater than 500Km/hr" );
                        model.Enabled = true;
                        year.Enabled = true; speed.Enabled = true;
                        gearcombobox.Enabled = true; color.Enabled = true;
                    }
                }
            }
        }
  
        // REMOVE BUTTON //
        private void remove_Click(object sender, EventArgs e)
        {
            if (Carsinfo.Count == 0)
                MessageBox.Show("There is NO Car in The List");
            else
            {
                if (MessageBox.Show("Are you Sure You Want To Remove The Selected Car?", "Warning!!",
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
                id.Text = AutoID.ToString();
            }
        }
        // FINDING NUMBER OF GEARTYPE BUTTON //
        private void numberof_Click(object sender, EventArgs e)
        {
            string carname = "";
            if (Carsinfo.Count == 0)
                MessageBox.Show("There is NO Car in The List");
            else
            {
                if (!manual.Checked && !automatic.Checked)
                    MessageBox.Show("Select a Gear Type.");
                else
                {
                    int cnt = 0;
                    if (manual.Checked)
                    {
                        for (int i = 0; i < Carsinfo.Count; i++)
                        {
                            if (Carsinfo[i].Gear == "Manual")
                            {
                                carname = Carsinfo[i].Model;
                                cnt++;
                            }
                        }
                        if (cnt == 1)
                            MessageBox.Show("There is only " + cnt + " Manual Car in the list: " + carname);
                        else
                            MessageBox.Show("There are " + cnt + " Manual Cars");
                    }
                    else
                    {
                        for (int i = 0; i < Carsinfo.Count; i++)
                        {
                            if (Carsinfo[i].Gear == "Automatic")
                            {
                                carname = Carsinfo[i].Model;
                                cnt++;
                            }
                        }
                        if (cnt == 1)
                            MessageBox.Show("There is only " + cnt + " Automatic Car in the list: " + carname);
                        else
                            MessageBox.Show("There are " + cnt + " Automatic Cars");
                    }
                }
            }
        }
        // YEAR TEXTBOX KEYPRESS HANDLING //
        private void year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Digits");
            }
        }
        // MAX_SPEED TEXTBOX KEYPRESS HANDLING //
        private void speed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Digits");
            }
        }
        // FINDING FASTEST CAR BUTTON//
        private void fastest_Click(object sender, EventArgs e)
        {
            if (Carsinfo.Count == 0)
                MessageBox.Show("There is No Car In The List");
            else
            {
                int Max = 0;
                String Name = "";
                
                for (int i = 0; i < Carsinfo.Count; i++)
                {
                    if (int.Parse(Carsinfo[i].MaxSpeed) > Max)
                    {
                        Max = int.Parse(Carsinfo[i].MaxSpeed);
                        Name = Carsinfo[i].Model;
                    }
                }    
                MessageBox.Show(Name + " is the fastest car with a speed of " + Max + "Km/h");
                
                
            }
        }

        private void mygrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id.Text = mygrid.SelectedCells[0].Value.ToString();
                model.Text = mygrid.SelectedCells[1].Value.ToString();
                year.Text = mygrid.SelectedCells[2].Value.ToString();
                gearcombobox.Text = mygrid.SelectedCells[3].Value.ToString();
                color.Text = mygrid.SelectedCells[4].Value.ToString();
                speed.Text = mygrid.SelectedCells[5].Value.ToString();
            }
            catch (System.ArgumentOutOfRangeException  ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // LINK LABEL //
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.Text == "Select")
                MessageBox.Show("Please Select a Brand");
            else
            {
                if (comboBox1.Text != comboBox1.Items.ToString())
                       MessageBox.Show("Please Select a Brand from the  DropDown Menu.");
               
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